﻿using System;
using TrainingWCFClient.ServiceReference1;

namespace TrainingWCFClient
{
	class Program
	{
		static void Main(string[] args)
		{
			//Step 1: Create an instance of the WCF proxy.
			CalculatorClient client = new CalculatorClient();

			// Step 2: Call the service operations.
			// Call the Add service operation.
			double value1 = 100.00D;
			double value2 = 15.99D;
			double result = client.Add(value1, value2);
			Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

			// Call the Subtract service operation.
			value1 = 145.00D;
			value2 = 76.54D;
			result = client.Subtract(value1, value2);
			Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

			// Call the Multiply service operation.
			value1 = 9.00D;
			value2 = 81.25D;
			result = client.Multiply(value1, value2);
			Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

			// Call the Divide service operation.
			value1 = 22.00D;
			value2 = 7.00D;
			result = client.Divide(value1, value2);
			Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

			//Step 3: Closing the client gracefully closes the connection and cleans up resources.
			client.Close();

			Console.Read();
		}
	}
}
