using System;
using System.Reflection;

namespace HW4 {						// Don't change namespace
	public class ReflectionSm24 {   // Don't change name of class
		/*
		 * Should search the public data members to see if searchString occurs anywhere
		 * in the structure. What this method does for CSE 465 students:
		 *     Search publicly declare string data members for the target string
		 *     Ignores non-string data members
		 *     Returns false if the passed object is null
		 *     Assumes that the object is a user-defined class
		 * This code should not crash
		 */
		public static bool SearchStructure(Object obj, String searchString) {
			if (obj == null)
				return false;

			Type objType = obj.GetType();
			FieldInfo[] fields = objType.GetFields
				(BindingFlags.Public | BindingFlags.Instance);

			foreach (FieldInfo field in fields) {
				if (field.FieldType == typeof(string)) {
					 string val = (string)field.GetValue(obj);
					 if (val != null && val.Contains(searchString)) {
						 return true;
					 }
				}
			}
			return false;
		}
		static void Main(string[] args) {
			Console.WriteLine("========================= Student =========================");
			Student student1 = new Student("John", "Doe", 3.5);
			Student student2 = new Student("Tommy", "John", 3.9);
			Console.WriteLine(SearchStructure(student1, "John"));   // true
			Console.WriteLine(SearchStructure(student2, "John"));   // true
			Console.WriteLine(SearchStructure(student1, "Juan"));   // false

			Console.WriteLine("========================= Album =========================");
			Album album1 = new Album("Beatles", "Meet the Beetles", "George Martin");
			Album album2 = new Album("The Who", "Who Are You?", "Glyn Johns, John Astley");
			Console.WriteLine(SearchStructure(album1, "Martin"));   // true
			Console.WriteLine(SearchStructure(album1, "Who"));      // false
			Console.WriteLine(SearchStructure(album2, "Martin"));   // false
			Console.WriteLine(SearchStructure(album2, "Who"));      // true
		}
	}
	/*
	 * The classes below are meant to be samples to be used for testing. You may
	 * change these. Also, be aware that your code should work with other class
	 * definitions.
	 */
	public class Student {
		public string firstName;
		public string lastName;
		public double GPA;
		public Student(string firstName, string lastName, double GPA) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.GPA = GPA;
		}
	}
	public class Album {
		public string artist;
		public string producer;
		public string name;
		public Album(string artist, string producer, string name) {
			this.artist = artist;
			this.producer = producer;
			this.name = name;
		}
	}
}
