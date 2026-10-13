using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book("C# for beginners", "Bill Gates", "12345678"));
books.Add(new Book("C# Methods and classes", "Microsoft", "55667778"));

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

foreach(Book book in books)
{
    Console.WriteLine($"\nBook Title: {book.Title}");
    Console.WriteLine($"Book Author: {book.Author}");
    Console.WriteLine($"Book ISBN: {book.ISBN}");
}

foreach (Member member in members)
{
    Console.WriteLine($"\nMember ID: {member.MemberId}");
    Console.WriteLine($"Member Name: {member.Name}");
    Console.WriteLine($"Member Address: {member.Address}");
    Console.WriteLine($"Member Phone: {member.Phone}");
}