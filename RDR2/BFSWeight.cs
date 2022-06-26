using System;
using System.Collections.Generic;
using System.Text;

namespace RDR2
{
    public class BFSWeight 
    {
        int v;
        public List<List<int>> adj;
        int source, dest;
        List<int> weights;


        public BFSWeight(int source, int dest,List<int> w)
        {
            this.source = source;
            this.dest = dest;
            this.weights = w;
            v = 25;
            adj = new List<List<int>>(v);
            initEdges();
        }

        public void initEdges()
        {
            for (int i = 0; i < v; i++)
            {
                adj.Add(new List<int>());
            }

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 20; y += 5)
                {
                    int i = x + y;
                    addEdge(adj, i, i + 1);
                    addEdge(adj, i, i + 5);
                }
            }
            //Loop for 4,9,...,19,24
            for (int i = 4; i < 24; i += 5)
            { addEdge(adj, i, i + 5); }
            //Loop for 20,21,..23,24
            for (int i = 20; i < 24; i += 1)
            { addEdge(adj, i, i + 1); }
        }


        private  void addEdge(List<List<int>> adj,int i, int j)
        {
            if (weights[j] > 1)
            {
                int pseudo = adj.Count;
                adj.Add(new List<int>());
                adj[i].Add(pseudo);
                adj[pseudo].Add(i);
                for (int p = 2; p < weights[j]; p++)
                {
                    pseudo++;
                    adj.Add(new List<int>());
                    adj[pseudo - 1].Add(pseudo);
                    adj[pseudo].Add(pseudo - 1);
                }   adj[pseudo].Add(j);
            }else{adj[i].Add(j);}
            
            if(weights[i]>1)
            {
                int pseudo = adj.Count;
                adj.Add(new List<int>());
                adj[j].Add(pseudo);
                adj[pseudo].Add(j);
                for (int p = 2; p < weights[i]; p++)
                {
                    pseudo++;
                    adj.Add(new List<int>());
                    adj[pseudo - 1].Add(pseudo);
                    adj[pseudo].Add(pseudo - 1);
                }   adj[pseudo].Add(i);
            }else { adj[j].Add(i); }
        }
        private  bool BFSAlgo(List<List<int>> adj, int src, int dest, int v, int[] pred, int[] dist)
        {

            List<int> queue = new List<int>();

            bool[] visited = new bool[adj.Count];

            for (int i = 0; i < adj.Count; i++)
            {
                visited[i] = false;
                dist[i] = int.MaxValue;
                pred[i] = -1;
            }


            visited[src] = true;
            dist[src] = 0;
            queue.Add(src);

            // bfs Algorithm
            while (queue.Count != 0)
            {
                int u = queue[0];
                queue.RemoveAt(0);
                
                for (int i = 0;
                         i < adj[u].Count; i++)
                {
                    if (visited[adj[u][i]] == false)
                    {
                        visited[adj[u][i]] = true;
                        dist[adj[u][i]] = dist[u] + 1;
                        pred[adj[u][i]] = u;
                        queue.Add(adj[u][i]);


                        if (adj[u][i] == dest)
                            return true;
                    }
                }
            }
            return false;
        }

        public List<int> GetShortestPath()
        {
            int a = adj.Count;
           

            int[] pred = new int[a];
            int[] dist = new int[a];

            if (BFSAlgo(adj, source, dest,
                    v, pred, dist) == false)
            {
                //No Connection
                return null;
            }

            // List to store path
            List<int> path = new List<int>();
            int crawl = dest;
            path.Add(crawl);

            while (pred[crawl] != -1)
            {
                path.Add(pred[crawl]);
                crawl = pred[crawl];
            }
            
            return path;
        }



    }
}
