﻿using System;

namespace GroupsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group[] groups = new Group[0];

            string opt;
            do
            {
                Console.WriteLine("1. Qrup elave et");
                Console.WriteLine("2. Qruplara bax");
                Console.WriteLine("3. Type deyerine gore qruplara bax");
                Console.WriteLine("4. Bugunedek baslamis qruplara bax");
                Console.WriteLine("5. Son 2 ayda baslamis qruplara bax");
                Console.WriteLine("6. Bu ayin sonunadek  baslayacaq qruplara bax");
                Console.WriteLine("7. Verilmis iki tarix araliginda baslayacaq qruplara bax");
                Console.WriteLine("0. Cixis");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("No:");
                        string no = Console.ReadLine();
                        Console.WriteLine("Type:");
                        foreach (var item in Enum.GetValues(typeof(GroupType)))
                            Console.WriteLine($"{(byte)item} - {item}");

                        byte typeByte;
                        string typeStr;
                        do
                        {
                            typeStr = Console.ReadLine();
                            typeByte = Convert.ToByte(typeStr);

                        } while (!Enum.IsDefined(typeof(GroupType),typeByte));

                        GroupType type = (GroupType)typeByte;


                        Console.WriteLine("StartDate:");
                        string startDatestr = Console.ReadLine();
                        DateTime startDate = Convert.ToDateTime(startDatestr);

                        Group group = new Group
                        {
                            No = no,
                            Type = type,
                            StartDate = startDate
                        };

                        Array.Resize(ref groups, groups.Length + 1);
                        groups[groups.Length - 1] = group;

                        break;
                    case "2":
                        foreach (var gr in groups)
                        {
                            Console.WriteLine($"No: {gr.No} - Type: {gr.Type} - StartDate: {gr.StartDate.ToString("dd-MM-yyyy HH:mm")}");
                        }
                        break;
                    case "3":
                        foreach (var item in Enum.GetValues(typeof(GroupType)))
                            Console.WriteLine($"{(byte)item} - {item}");
                        Console.WriteLine("Type:");
                        typeStr = Console.ReadLine();
                        typeByte = Convert.ToByte(typeStr);
                        type = (GroupType)typeByte;

                        foreach (var gr in groups)
                        {
                            if (gr.Type == type)
                                Console.WriteLine($"No: {gr.No} - Type: {gr.Type} - StartDate: {gr.StartDate.ToString("dd-MM-yyyy HH:mm")}");
                        }
                        break;
                    case "4":
                        foreach (var gr in groups)
                        {
                            if (gr.StartDate.Date < DateTime.Now.Date)
                                Console.WriteLine($"No: {gr.No} - Type: {gr.Type} - StartDate: {gr.StartDate.ToString("dd-MM-yyyy HH:mm")}");

                        }
                        break;

                    case "5":
                        foreach (var gr in groups)
                        {
                            if (gr.StartDate < DateTime.Now && gr.StartDate>DateTime.Now.AddMonths(-2))
                                Console.WriteLine($"No: {gr.No} - Type: {gr.Type} - StartDate: {gr.StartDate.ToString("dd-MM-yyyy HH:mm")}");
                        }
                        break;
                    case "6":
                        foreach (var gr in groups)
                        {
                            var now = DateTime.Now;
                            if (gr.StartDate>=now && gr.StartDate.Month ==now.Month && gr.StartDate.Year == now.Year )
                                Console.WriteLine($"No: {gr.No} - Type: {gr.Type} - StartDate: {gr.StartDate.ToString("dd-MM-yyyy HH:mm")}");
                        }
                        break;
                    case "7":
                        Console.WriteLine("FromDate");
                        DateTime fromDate = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("ToDate");
                        DateTime toDate = Convert.ToDateTime(Console.ReadLine());


                        foreach (var gr in groups)
                        {
                            if (gr.StartDate>fromDate && gr.StartDate<toDate)
                                Console.WriteLine($"No: {gr.No} - Type: {gr.Type} - StartDate: {gr.StartDate.ToString("dd-MM-yyyy HH:mm")}");
                        }
                        break;
                    case "0":
                        Console.WriteLine("Proqram bitdi");
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir");
                        break;
                }

            } while (opt!="0");
           




        }


    }
}
