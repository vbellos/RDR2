using System;
using System.Collections.Generic;
using System.Text;

namespace RDR2
{
    public class BFS
    {
        int v;
        public List<List<int>> adj;
        int source, dest;

        public BFS(int source,int dest)
        {
            this.source = source;
            this.dest = dest;
            v = 25;
            adj = new List<List<int>>(v);
            initEdges();
        }

        public void initEdges()
        {
            for (int i = 0; i < v; i++)
            { adj.Add(new List<int>()); }

            //  0-->1-->2-->3--> | 4
            //  v   v   v   v    | v
            //  5-->6-->7-->8--> | 9
            //  v   v   v   v    | v
            //  10->11->12->13-> | 14
            //  v   v   v    v   | v
            //  15->16->17->18-> | 19
            //  v   v   v    v   | v
            //  ---------------- | --
            //  20->21->22->23-> | 24
 
            //Loop for 1,2,...,17,18
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

        private static void addEdge(List<List<int>> adj,int i, int j)
        {
            adj[i].Add(j);
            adj[j].Add(i);
        }



        private static bool BFSAlgo(List<List<int>> adj, int src, int dest, int v, int[] pred, int[] dist)
        {
            List<int> queue = new List<int>();

            bool[] visited = new bool[v];

            for (int i = 0; i < v; i++)
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
                        if (adj[u][i] == dest) { return true; }
                    }
                }
            }
            return false;
        }

        public List<int> GetShortestPath()
        {
            int[] pred = new int[v];
            int[] dist = new int[v];
            if (BFSAlgo(adj, source, dest,v, pred, dist) == false){return null;}
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


