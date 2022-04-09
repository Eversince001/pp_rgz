using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace vkr
{
    class GetTargetFunction
    {
        int D, V, N, R, S, h1 = 0, h2;
        Result Result = new Result();
        List<Task> downloadTasks = new List<Task>();
        int a = 0;

        public GetTargetFunction(int r, int s, int n, int d, int v)
        {

            D = d; N = n; V = v; R = r; S = s;
        }
        void swap(ref List<List<int>> Data, int i, int j, ref List<int> A)
        {
            List<int> s = Data[i];
            int a = A[i];
            A[i] = A[j];
            A[j] = a;
            Data[i] = Data[j];
            Data[j] = s;
        }
        bool NextSet(ref List<List<int>> Data, ref List<int> A)
        {
            int j = A.Count - 2;
            while (j != -1 && A[j] >= A[j + 1]) j--;
            if (j == -1)
                return false; // больше перестановок нет
            int k = A.Count - 1;
            while (A[j] >= A[k]) k--;
            swap(ref Data, j, k, ref A);
            int l = j + 1, r = A.Count - 1; // сортируем оставшуюся часть последовательности
            while (l < r)
                swap(ref Data, l++, r--, ref A);
            return true;
        }
        int GetM(List<List<int>> DataRR, List<List<int>> DataSS, List<int> LoadTime)
        {
            List<int> Ci = new List<int>();
            List<int> Cj = new List<int>();
            List<int> B = new List<int>();

            List<List<int>> DataR = new List<List<int>>();
            List<List<int>> DataS = new List<List<int>>();

            for (int i = 0; i < R; i++)

            {

                DataR.Add(new List<int>());

                for (int j = 0; j < N; j++)

                    DataR[i].Add(DataRR[i][j]);



            }

            for (int i = 0; i < S; i++)
            {
                DataS.Add(new List<int>());
                for (int j = 0; j < N; j++)
                    DataS[i].Add(DataSS[i][j]);
            }



            List<int> products = new List<int>();

            int Sum = 0;
            B.Add(0);
            int sum = 0;

            for (int i = 0; i < N; i++)
            {

                sum += DataR[0][i] * LoadTime[0];
            }
            Ci.Add(sum);



            for (int i = 1; i < R; i++)
            {
                sum = 0;
                for (int j = 0; j < N; j++)
                {
                    sum += DataR[i][j] * LoadTime[j];
                }
                Ci.Add(D + sum + Ci[i - 1]);
            }



            for (int i = 1; i < R; i++)
            {
                B.Add(Ci[i - 1] + D);
            }

            for (int i = 0; i < R; i++)
            {
                products.Add(0);
            }

            for (int i = 0; i < S; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (DataS[i][j] != 0)
                        for (int k = 0; k < R; k++)
                        {
                            if (DataR[k][j] >= DataS[i][j])
                            {
                                DataR[k][j] -= DataS[i][j];
                                products[k] += DataS[i][j] * LoadTime[0];
                                k = R;
                            }



                            else if (DataR[k][j] < DataS[i][j] && DataR[k][j] != 0)
                            {
                                DataS[i][j] -= DataR[k][j];
                                products[k] = DataR[k][j] * LoadTime[0];
                                DataR[k][j] = 0;
                            }
                        }

                }

                for (int n = 0; n < R; n++)
                {
                    if (products[n] != 0)
                    {
                        Sum = B[n] + D + V + products[n];
                    }

                    if (h1 < Sum)
                    {
                        h1 = Sum;
                    }

                }

                if (i == 0)
                {
                    Cj.Add(h1);
                }
                else
                {
                    h2 = Cj[i - 1] + D;
                    for (int m = 0; m < products.Count; m++)
                        h2 += products[m];

                    if (h2 > h1)
                    {
                        Cj.Add(h2);
                    }
                    else
                    {
                        Cj.Add(h1);
                    }
                }

                products.Clear();
                h1 = 0;
                Sum = 0;
                for (int m = 0; m < R; m++)
                {
                    products.Add(0);
                }

            }

            int tmp = Cj[S - 1];
            Ci.Clear();
            B.Clear();
            Cj.Clear();
            return tmp;
        }
        public Result GetResult(List<List<int>> DataR, List<List<int>> DataS, List<int> LoadTime)
        {
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = 2;
            List<int> K = new List<int>(); int m = 1;
            List<int> R = new List<int>();
            List<int> S = new List<int>();
            List<List<int>> DataSS = new List<List<int>>();

            for (int i = 0; i < DataS.Count; i++)
            {
                DataSS.Add(new List<int>());
                for (int j = 0; j < N; j++)
                    DataSS[i].Add(DataS[i][j]);

            }

            for (int i = 0; i < DataR.Count; i++)
                R.Add(i);

            for (int i = 0; i < DataS.Count; i++)
                S.Add(i);

            Result.M = GetM(DataR, DataSS, LoadTime);

            for (int i = 0; i < DataR.Count; i++)
                Result.PR.Add(i);
            for (int i = 0; i < DataS.Count; i++)
                Result.PS.Add(i);

            while (NextSet(ref DataSS, ref S))
            {
                K.Add(GetM(DataR, DataSS, LoadTime));
                // Console.WriteLine(K);
                m++;
                if (Result.M > K[K.Count - 1])
                {
                    Result.M = K[K.Count - 1];
                    for (int i = 0; i < Result.PR.Count; i++)
                        Result.PR[i] = R[i];
                    for (int i = 0; i < Result.PS.Count; i++)
                        Result.PS[i] = S[i];
                }
            }
            
            while (NextSet(ref DataR, ref R))
            {

                S.Clear();
                for (int i = 0; i < DataS.Count; i++)
                    S.Add(i);

                DataSS.Clear();
                for (int i = 0; i < DataS.Count; i++)
                {
                    DataSS.Add(new List<int>());
                    for (int j = 0; j < N; j++)
                        DataSS[i].Add(DataS[i][j]);

                }

                do
                {
                    downloadTasks.Add(new Task(() => {
                        K.Add(GetM(DataR, DataSS, LoadTime));
                    }));

                    downloadTasks[downloadTasks.Count - 1].Start();
                    
                } while (NextSet(ref DataSS, ref S));

                Task.WaitAll(downloadTasks.ToArray());
            }
            for (int j = 0; j < K.Count; j++)
            {
                if (Result.M > K[j])
                {
                    Result.M = K[j];
                    for (int i = 0; i < Result.PR.Count; i++)
                        Result.PR[i] = R[i];
                    for (int i = 0; i < Result.PS.Count; i++)
                        Result.PS[i] = S[i];
                }
            }
          

            return Result;
        }
    }

}

