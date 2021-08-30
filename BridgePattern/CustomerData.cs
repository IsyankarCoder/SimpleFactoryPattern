using System; 
using System.Collections; 
using System.Collections.Generic; 

namespace BridgePattern {

/// <summary>
/// The  'Concrete Implementor ' class
/// </summary>
public class CustomersData:DataObject {
private readonly List < string > customers = new List < string > (); 
private int current = 0; 
private string _city; 

public CustomersData(string city) {
this._city = city; 

customers.Add("Jim Jones"); 
customers.Add("Samuel Jackson"); 
customers.Add("Allen Good"); 
customers.Add("Ann Stilss"); 
customers.Add("Lisa Gioalni"); 
}


public override void AddRecord(string name) {
customers.Add(name); 
}

public override void DeleteRecord(string name) {
customers.Remove(name); 
}

public override string GetCurrentRecord() {
return customers[current]; 
}

public override void NextRecord() {
if (current <= customers.Count-1)
current++; 
}

public override void PriorRecord() {
if (current > 0)
current--; 
}

public override void ShowAllRecords() {
Console.WriteLine("Customer City : " + _city); 
foreach (string customer in customers) {
Console.WriteLine(" " + customer); 
}
}

public override void ShowRecord() {
Console.WriteLine(customers[current]); 
}
}
}