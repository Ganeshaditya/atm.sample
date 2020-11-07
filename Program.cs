using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int tray100 = 10, tray500 = 5, tray2000 = 2, u2 = 1234, p2 = 1218, pin, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r;
            string u1 = "ram", p1 = "gan", name;
            Console.WriteLine("Enter your name:");
            name = (Console.ReadLine());
            Console.WriteLine("Enter your pin:");
            pin = int.Parse(Console.ReadLine());
            if ((name == u1 && pin == u2) || (name == p1 && pin == p2))
            {
                Console.WriteLine("Enter the amount:");
                c = int.Parse(Console.ReadLine());
                if (c >= 2000)
                {
                    if (tray2000 != 0)
                    {
                        a = c % 2000;


                        b = c / 2000;
                        if (tray2000 >= b)
                        {
                            d = tray2000 - b;
                            e = tray2000 - d;
                            f = e * 2000;

                            if (tray500 != 0 && tray100 != 0)
                            {
                                g = c % 2000;
                                h = g / 500;
                                if (h <= tray500)
                                {
                                    i = tray500 - h;
                                    j = tray500 - i;
                                    k = j * 500;
                                    q = f + k;
                                    Console.WriteLine("Take your cash" + f + "+" + k);
                                    Console.WriteLine("Total=" + q);
                                    l = g % 500;
                                    m = l / 100;
                                    if (l != 0)
                                    {
                                        if (m != 0 && tray100 >= m)
                                        {
                                            n = tray100 - m;
                                            o = tray100 - n;
                                            p = o * 100;
                                            q = f + k + p;
                                            Console.WriteLine("take your cash" + f + "+" + k + "+" + p);
                                            Console.WriteLine("Total=" + q);
                                        }
                                        else
                                        {
                                            Console.WriteLine("unable to dispense cash");
                                        }
                                    }

                                }
                                else if (h > tray500 && tray100 >= h)
                                {
                                    i = tray100 - h;
                                    j = tray100 - i;
                                    k = j * 100;
                                    q = f + k;
                                    Console.WriteLine("take your cash" + f + "+" + k);
                                    Console.WriteLine("Total=" + q);
                                }
                                else if (tray100 < h)
                                {
                                    Console.WriteLine("unable to dispense cash");
                                }

                            }


                        }
                        else if (tray2000 < b)
                        {
                            d = b - tray2000;
                            e = b - d;
                            f = e * 2000;
                            if (tray500 != 0 && tray100 != 0)
                            {
                                g = c - f;
                                h = g / 500;
                                if (h <= tray500)
                                {
                                    i = tray500 - h;
                                    j = tray500 - i;
                                    k = j * 500;
                                    q = f + k;
                                    Console.WriteLine("Take your cash" + f + "+" + k);
                                    Console.WriteLine("Total=" + q);
                                    l = g % 500;
                                    m = l / 100;
                                    if (l != 0)
                                    {
                                        if (m != 0 && tray100 >= m)
                                        {
                                            n = tray100 - m;
                                            o = tray100 - n;
                                            p = o * 100;
                                            q = f + k + p;
                                            Console.WriteLine("take your cash" + f + "+" + k + "+" + p);
                                            Console.WriteLine("Total=" + q);
                                        }
                                        else
                                        {
                                            Console.WriteLine("unable to dispense cash");
                                        }
                                    }

                                }
                                else if (h > tray500 && tray100 >= h)
                                {
                                    i = h - tray500;
                                    j = h - i;
                                    k = j * 500;
                                    m = g - k;
                                    r = m / 100;
                                    n = tray100 - m;
                                    o = tray100 - n;
                                    p = o * 100;
                                    q = f + k + p;
                                    Console.WriteLine("take your cash" + f + "+" + k + "+" + p);
                                    Console.WriteLine("Total=" + q);
                                }
                                else if (tray100 < h)
                                {
                                    Console.WriteLine("unable to dispense cash");
                                }

                            }

                        }
                    }
                }

                else if (c >= 500)
                {
                    if (tray500 != 0)
                    {
                        a = c % 500;
                        b = c / 500;
                        if (tray500 >= b)
                        {
                            d = tray500 - b;
                            e = tray500 - d;
                            f = e * 500;
                            h = a / 100;
                            if (tray100 != 0 && h <= tray100)
                            {
                                g = c % 500;
                                h = g / 100;


                                i = tray100 - h;
                                j = tray100 - i;
                                k = j * 100;
                                q = f + k;
                                Console.WriteLine("Take your cash" + f + "+" + k);
                                Console.WriteLine("Total=" + q);

                            }
                            else
                            {
                                Console.WriteLine("Unable to dispense cash");
                            }
                        }
                        else if (tray500 < b)
                        {
                            d = b - tray500;
                            e = b - d;
                            f = e * 500;
                            g = c - f;
                            h = g / 100;
                            i = h * 100;
                            q = f + i;
                            Console.WriteLine("Take your cash" + f + "+" + i);
                            Console.WriteLine("Total=" + q);
                        }
                        else
                        {
                            Console.WriteLine("unable to dispense cash");
                        }
                    }
                }
                else if (tray100 != 0 && c >= 100)
                {
                    a = c % 100;
                    b = c / 100;
                    if (tray100 > b)
                    {
                        d = tray100 - b;
                        e = tray100 - d;
                        f = e * 100;
                        Console.WriteLine("Take your cash" + f);
                    }
                    else
                    {
                        Console.WriteLine("Unable to dispense cash");
                    }
                }
                else
                {
                    Console.WriteLine("unable to dispense cash");
                }



            }
            else
            {
                Console.WriteLine("Wrong name or pin");
            }
        }
    }
}





