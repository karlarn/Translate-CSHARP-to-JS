using System;
using System.Collections.Generic;

namespace dinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Table guests = new Table();
            
            guests.TableList.Add(new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model"));

            guests.TableList.Add(new Guest("Abraham Lincoln","politician", "(1809 - 1865) US President during American civil war" ));

            guests.TableList.Add(new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner"));

            guests.TableList.Add(new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist"));

            guests.TableList.Add(new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian"));

            guests.TableList.Add(new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"));

            guests.TableList.Add(new Guest("Admiral Grace Hopper", "computer scientist", "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"));

            guests.TableList.Add(new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977"));

            Table tableOne = new Table();
            Table tableTwo = new Table();
            

            foreach(Guest i in guests.TableList)
            {
                bool isTrue = tableOne.TableList.Exists(g=>g.Occupation==i.Occupation);
                if(isTrue)
                {
                    tableTwo.TableList.Add(i);
                }
                else
                {
                    tableOne.TableList.Add(i);
                }
            }
            Console.WriteLine("Table 1");
            foreach(Guest i in tableOne.TableList)
            {
                Console.WriteLine($"{i.Name} ({i.Occupation}) {i.Bio}");
            }
            Console.WriteLine("Table 2");
            foreach(Guest i in tableTwo.TableList)
            {
                Console.WriteLine($"{i.Name} ({i.Occupation}) {i.Bio}");
            }

        }
    }
}
