using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

internal class Program
{
    static void InMang(int[][] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void BaiTap01()
    {
        Console.WriteLine("--- BAI TAP 1 ---");

        int[][] Mang =
        {
            new int[] {1, 1, 1, 1, 1},

            new int[] {2, 2},

            new int[] {3, 3, 3, 3},

            new int[] {4, 4}

        };

        InMang(Mang);

        Console.WriteLine();
    }
    static void BaiTap02()
    {
        Console.WriteLine("--- BAI TAP 2 ---");

        Console.Write("Nhập số dòng: ");

        int m = int.Parse(Console.ReadLine()!);

        int[][] a = new int[m][];

        for (int i = 0; i < m; i++)
        {
            Console.Write($"Nhập số cột của dòng {i}: ");

            int n = int.Parse(Console.ReadLine()!);

            a[i] = new int[n];

            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i}][{j}]: ");

                a[i][j] = int.Parse(Console.ReadLine()!);
            }
        }
        Console.WriteLine("In Mảng: ");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Init(string[][,] emps)
    {
        emps[0] = new string[5, 3]
        {
            {"01", "Vo Thanh Vien", "36" },
            {"02", "Cao Bach Tng", "18" },
            {"03", "Ngo Sy Nhan", "7" },
            {"04", "Pham Ho Duy Khanh", "12" },
            {"05", "Le Gia Phuc", "10" },
        };

        emps[1] = new string[3, 3]
        {
            {"06", "Nguyen Van A", "23" },
            {"07", "Pham Van B", "6"},
            {"08", "Le Thi C", "2" },
        };

        emps[2] = new string[6, 3]
        {
            {"09", "Le Van D", "4" },
            {"10", "Ngo Sy E", "22" },
            {"11", "Nguyen Thi F", "1" },
            {"12", "Pham Ho Duy G", "20" },
            {"13", "Le Gia H", "3" },
            {"14", "Vo Thanh I", "11" },
        };
    }
    static void PrintMember(string[][,] emps)
    {
        foreach (string[,] row in emps)
        {
            for (int i = 0; i < row.GetLength(0); i++)
            {
                Console.WriteLine($"Id: {row[i, 0]}, Name: {row[i, 1]}, Tasks: {row[i, 2]}");
            }
        }
    }

    static void PrintMemberID(string[][,] emps, string id)
    {
        bool found = false; 

        foreach (string[,] row in emps)
        {
            for (int i = 0; i < row.GetLength(0); i++)
            {
                if (row[i, 0] == id)
                {
                    Console.WriteLine($"Id: {row[i, 0]}, Name: {row[i, 1]}, Tasks: {row[i, 2]}");
                    found = true;
                    break;
                }
            }
        }
        if (!found)
        {
            Console.WriteLine($"Không tìm thấy nhân viên có id = {id}");
        }
    }

    static string[] SearchMember(string[][,] emps, string id)
    {
        foreach (string[,] row in emps)
        {
            for (int i = 0; i < row.GetLength(0); i++)
            {
                if (row[i, 0] == id)
                {
                    return new string[] { row[i, 0], row[i, 1], row[i, 2] };
                }
            }
        }
        return null!;
    }

    static string[] PrintMostTask(string[][,] emps)
    {
        string[] empsMaxTasks = null!;

        int max = 0;

        foreach (string[,] row in emps)
        {
            for (int i = 0; i < row.GetLength(0); i++)
            {
                int tasks = int.Parse(row[i, 2]);

                if (tasks > max)
                {
                    max = tasks;

                    empsMaxTasks = new string[] { row[i, 0], row[i, 1], row[i, 2] };
                }
            }
        }
        return empsMaxTasks;
        
    }
    public static void BaiTap03()
    {
        Console.WriteLine("--- BAI TAP 3 ---");

        string[][,] emps = new string[3][,];

        Init(emps);

        Console.WriteLine("--- DANH SÁCH NHÂN VIÊN ---");

        PrintMember(emps);

        Console.WriteLine();

        Console.Write("Nhập id Nhân viên muốn in: ");

        string id = Console.ReadLine()!;

        PrintMemberID(emps, id);

        Console.WriteLine();

        Console.WriteLine("--- THÔNG TIN CỦA NHÂN VIÊN KHI BIẾT ID ---");

        string[] foundMember = SearchMember(emps, id);

        if (foundMember != null)
        {
            Console.WriteLine($"Id: {foundMember[0]}, Name: {foundMember[1]}, No Tasks: {foundMember[2]}");
        }

        Console.WriteLine();

        string[] mve = PrintMostTask(emps);

        Console.Write("Nhân viên siêng năng nhất =)))))): ");

        Console.WriteLine($"Id: {mve[0]}, Name: {mve[1]}, No Tasks: {mve[2]}");
    }

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.InputEncoding = Encoding.UTF8;

        //BaiTap01();

        //BaiTap02();

        //BaiTap03();

        Console.ReadKey();
    }
}