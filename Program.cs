


// string collection (data source)
IList<string> stringList = new List<string>() { 
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java" 
};



// LINQ Query Syntax
var result = from s in stringList
            where s.Contains("Tutorials") 
            select s;


            
            
// LINQ Query Executation
            foreach (var str in result)
		{
			Console.WriteLine(str);
		}