// Acquisire le informazioni generiche del libro

String bookName = "Clean Code";
String authorName = "Robert C. Martin";
String codiceIsbn13 = "978-0132350884";
int pageNumber = 431;
float bookWeight = 0.8f;
float bookWidth = 17.78f;
float bookLenght = 23.37f;
float bookHeight = 2.79f;

//Acquisire le informazioni di Amazon

int votesNumber = 5413;
float averageRating = 4.7f;
String avaiableOnKindle = "Sì";
String flexibleCover = "Sì";

// Stampare a console il Riepilogo

Console.WriteLine("-------- IL LIBRO DI OGGI: " + bookName + " di " + authorName + " ------------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + codiceIsbn13);
Console.WriteLine("Numero delle pagine: " + pageNumber + " pagine");
Console.WriteLine("Peso del libro: " + bookWeight + " kg");
Console.WriteLine("Dimensioni del libro: " + bookWidth + " cm x " + bookLenght + " cm x " + bookHeight + " cm");
Console.WriteLine("");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + votesNumber + " recensioni");
Console.WriteLine("Valutazione media:" + averageRating + " stelline");
Console.WriteLine("Kindle disponibile: " + avaiableOnKindle);
Console.WriteLine("Copertina flessibile: " + flexibleCover);
Console.WriteLine("---------------------------------------------------------------------------");