using QuickGraph;
using QuickGraph.Algorithms;
using System;
using System.IO;

namespace ConsoleApplication2
{
	class Program
	{

		public static void ParseFile(AdjacencyGraph<String, SEdge<String>> graph, string inputFile)
		{
			var reader = new StreamReader(File.OpenRead(inputFile));
			string line;
			while ((line=reader.ReadLine())!=null)
			{
				line = line.Trim();
				if (!string.IsNullOrWhiteSpace(line))
				{
					var nodes = line.Split(new char[] {'>',' '}, StringSplitOptions.RemoveEmptyEntries);
					var firstNode = nodes[0];
					var secondNode = nodes[1];
					graph.AddVertex(firstNode);
					graph.AddVertex(secondNode);
					graph.AddEdge(new SEdge<string>(firstNode, secondNode));
				}
			}

		}

		static void Main(string[] args)
		{
			var graph = new AdjacencyGraph<String, SEdge<String>>();
			ParseFile(graph, args[0]);
			foreach (var element in graph.TopologicalSort())
			{
				Console.WriteLine(element);
			}
		}
	}
}
