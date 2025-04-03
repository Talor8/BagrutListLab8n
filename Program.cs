namespace BagrutListLab8n;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Node<int> lst = new Node<int>(5);//יצירת חוליה ראשונה ששם הרשימה מצביע עליה
                                         //null בעת היצירה החוליה היחידה מצביעה על
        Console.WriteLine(lst);
        Node<int> currNode = new Node<int>(7, lst);//יצירת חוליה נוספת, שמוצבת לפני ליסט ומצביעה
                                                   //על החוליה הראשונה של ליסט
        lst = currNode;//גורמים למצביע ליסט להצביע על החוליה שהוספנו בתחילת הרשימה
        Console.WriteLine(lst);
        currNode = new Node<int>(9, lst);
        lst = currNode;
        currNode = new Node<int>(-2, lst);
        lst = currNode;
        currNode = new Node<int>(10, lst);
        lst = currNode;
        currNode = new Node<int>(22, lst);
        lst = currNode;
        currNode = new Node<int>(1, lst);
        lst = currNode;
        currNode = new Node<int>(-1, lst);
        lst = currNode;
        currNode = new Node<int>(-9, lst);
        lst = currNode;
        lst = new Node<int>(-55, lst);//צורת כתיבה שמאפשרת להוסיף חוליה בראש שרשרת החוליות ולהעביר אתיה את מצביע ראש הרשימה
        Console.WriteLine(lst);

        Console.WriteLine(lst.GetValue());//הדפסת הערך של החוליה הראשונה ברשימה

        Console.WriteLine(lst.GetNext().GetValue());//הדפסת הערך של החוליה השנייה ברשימה

        currNode = lst.GetNext();//הצבעה על החוליה השניה בשרשרת החוליות

        currNode = currNode.GetNext();//קידום ההצבעה של החוליות הנוכחית באחת

        //שילוב חוליה חדשה בשרשרת אחרי חוליה נתונה
        //נהנה למשל שרשרת חוליות מסודרת בסדר עולה
        Node<int> lst1 = new Node<int>(10);// 10-->null
        lst1 = new Node<int>(8, lst1);// 8-->10-->null
        lst1 = new Node<int>(6, lst1);// 6-->8-->10-->null
        //lst1 = new Node<int>(4, lst1);// 4-->6-->8-->10-->null
        Console.WriteLine(lst1);

        //ניצור חולייה חדשה ונכניס אותה לשרשרת לפי ערך המספר
        Node<int> NewNode = new Node<int>(12);// 7-->null
        currNode = lst1;//הצבעה על החוליה הראשונה בשרשרת
        if (currNode.GetValue() > NewNode.GetValue())
        {
            NewNode.SetNext(lst1);//הצבת החוליה החדשה לפני החוליה הראשונה בשרשרת
            lst1 = NewNode;//ההצבת שם השרשרת על המספר החדש שנוסף בראשה
        }
        else
        {
            while (currNode.HasNext() && currNode.GetNext().GetValue() < NewNode.GetValue())
            {
                currNode = currNode.GetNext();//כל עוד יש חוליה עוקבת והערך שלה קטן מהחוליה החדשה מתקדמים חוליה
            }
            NewNode.SetNext(currNode.GetNext());//הצבת החוליה החדשה לפני החוליה העוקבת את הנוכחית
            currNode.SetNext(NewNode);//הצבת החוליה החדשה אחרי החוליה הנוכחית        
        }
        Console.WriteLine(lst1);
        Console.WriteLine(OrehList(lst1));
        bool result=BigThenSmall(lst1);
        Console.WriteLine(result);
        Range1 myRange = new Range1(1, 10);
        Console.WriteLine(myRange);
        Node<Range1> rLst= new Node<Range1>(myRange);

    }
    public static int OrehList(Node<int> lst1)
    {
        int sum = 0;
        Node<int> currNode = lst1;
        while (currNode != null)
        {
            sum++;
            currNode = currNode.GetNext();
        }
        return sum;
    }
    public static bool BigThenSmall(Node<int> lst1)
    {
        Node<int> currNode = lst1;
        int max=currNode.GetValue();
        int len= OrehList(lst1);
        for(int i = 0; i < len / 2; i++)
        {
            if (currNode.GetValue() > max)
            {
                max = currNode.GetValue();
            }
            currNode = currNode.GetNext();
        }
        int min=currNode.GetValue();
        while (currNode != null) 
        {
            if(currNode.GetValue() < min)
            {
                min = currNode.GetValue();
            }
            currNode = currNode.GetNext();
        }
        if(max < min)
        {
            return false;
        }
        return true;
    }
    /*public static bool RangeChck(Node<Range1> lst,int num) 
    {
        Node<Range1> currNode = lst;
        for(int i = 0;)
        
    }*/

}