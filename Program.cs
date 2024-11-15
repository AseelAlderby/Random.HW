using System;
namespace Myproject
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int minNum;
			int maxNum;

			Console.Write("enter minNum: ");
			minNum=int.Parse(Console.ReadLine());

			Console.Write("enter maxNum: ");
			maxNum = int.Parse(Console.ReadLine());
			
			Random rNum = new Random();
            
			 int[] element=new int[1000];
			int[,] finalArray = new int[maxNum,2];
			
			for (int i = 0; i <= element.Length-1; i++)
			element[i] = rNum.Next(minNum,maxNum);

			/*for (int i = 0; i <= element.Length - 1; i++)//صح outputبس اذا بدي اتاكد ان ال  random elements هاد الجزء بطبع 
				Console.Write(element[i]);
			Console.WriteLine();*/

				int ComparisonElement;
			    int result;
			int row=0;
			

				for (ComparisonElement = minNum; ComparisonElement <= maxNum; ComparisonElement++)//maxNum لحد minNum باخد كل عنصر من
				{
				    
					result = 0;
					for (int i = 0; i <= element.Length - 1; i++)//  element array(random elements)وبقارنو ب ال1000 عنصر اللي خزنتهم ب 
					{
						if (ComparisonElement == element[i])
							result++;
					}
					
					

						finalArray[row, 0] = ComparisonElement;
						finalArray[row, 1] = result;
                        row++;
				

					


				}
			Console.WriteLine("Number" + "   " + "Frequency");
			for (int Row = 0; Row < maxNum; Row++)
			{
				
					Console.WriteLine(finalArray[Row,0] + "         " + finalArray[Row, 1]);

			}

			}
			
		}

	}

