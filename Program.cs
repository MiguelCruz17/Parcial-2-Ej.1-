using System;

namespace Parcial_2_Ej._1_
{
    class producto
    {
        private string[] nombre = new string[8] {"Lays", " Refresco (Cocacola)", "Oreo", 
        "Agua planeta azul", "Refresco (Uva)", "Choki", "Hojuelitas", "Mas Mas"};
        
        private int[] existencia = new int[8] {10, 8, 15, 8, 8, 11, 13, 20};

        
        private int[] precio = new int[8] {30, 20, 20, 15, 20, 35, 15, 25};
        
        public producto ()
        {           
        }
    
    
        public void imprimir ()
        {
            Console.Clear();
            Console.WriteLine("Elija un producto");
            Console.WriteLine("0. Lays $30");
            Console.WriteLine("1. Refresco (Cocacola) $20");
            Console.WriteLine("2. Oreo $20");
            Console.WriteLine("3. Agua planeta azul $15");
            Console.WriteLine("4. Refresco (Uva) $20");
            Console.WriteLine("5. Choki $35");
            Console.WriteLine("6. Hojuelitas $15");
            Console.WriteLine("7. Mas Mas $25");
            int a = int.Parse(Console.ReadLine());
            existencia[a]-=1; 
            Console.Clear();
            if (a==0 | a==1 |  a==2 |  a==3 |  a==4 |  a==5 |  a==6 |  a==7)
            {
                int x=1, b, cinco=0, diez=0, vcinco=0, cin=0, cien=0, devuelta;
                Console.WriteLine("Deposite {0} pesos",precio[a]);
                Console.WriteLine("Ingrese moneda de 5, 10, 25");
                Console.WriteLine("Ingrese billete de 50, 100, 200");
                b = int.Parse(Console.ReadLine());
                x=precio[a]-b;
                 
                do
                {
                    if (b==5 | b==10 |  b==25 |  b==50 |  b==100 |  b==200)
                    {
                        
                        if (x<0)
                        {
                            x*=-1;
                            cien=x/100;   
                            if (cien>0)
                            {
                                Console.WriteLine("Retire {0} billetes de cien",cien);
                                x%=100;
                            }
                            if (x>0)
                            {
                                cin=x/50;
                                if (cin>0)
                                {
                                    Console.WriteLine("Retire {0} billetes de cincuenta",cin);
                                    x%=50;
                                }
                            }
                            if (x>0)
                            {
                                vcinco=x/25;
                                if (vcinco>0)
                                {
                                    Console.WriteLine("Retire {0} monedas de veinte y cinco",vcinco);
                                    x%=25;
                                }
                            }
                            if (x>0)
                            {
                                diez=x/10;
                                if (diez>0)
                                {
                                    Console.WriteLine("Retire {0} monedas de diez",diez);
                                    
                                    x%=10;
                                }
                            }
                            if (x>0)
                            {
                                cinco=x/5;
                                if (cinco>0)
                                {
                                    Console.WriteLine("Retire {0} monedas de cinco",cinco);
                                    x%=5;
                                }
                            }
                            devuelta=(cien*100+cin*50+vcinco*25+diez*10+cinco*5);
                            Console.WriteLine("Para un total de {0} pesos",devuelta);
                            Console.WriteLine("Disfrute su {0}",nombre[a]);
                        }
                        else
                        {
                            if (x==0)
                            {
                                Console.Clear();
                                Console.WriteLine("Disfrute su {0}",nombre[a]);
                            }
                            else
                            {
                                Console.WriteLine("Deposite {0} pesos",x);
                                Console.WriteLine("Ingrese moneda de 5, 10, 25");
                                Console.WriteLine("Ingrese billete de 50, 100, 200");
                                b = int.Parse(Console.ReadLine());
                                x-=b;
                                if (x==0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Disfrute su {0}",nombre[a]);
                                }
                            }
                        }
                
                    }
                    else
                    {
                        Console.WriteLine("Deposite una cantidad válida");
                    }      
                    Console.ReadLine();
                }while(x!=0);
            }
        }
            static void Main(string[] args)
        {
            int opcion = 0,i;
            int[] existencia = new int[8] {10, 8, 15, 8, 8, 11, 13, 20};
            string[] nombre = new string[8] {"Lays", " Refresco (Cocacola)", "Oreo", 
            "Agua planeta azul", "Refresco (Uva)", "Choki", "Hojuelitas", "Mas Mas"};
            do
            {
                Console.Clear();
                Console.WriteLine("Opciones\n" +
                "1.-Continuar venta\n" +
                "2.-Mostrar informe\n" +
                "3.-Salir"
                );
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        producto prod = new producto();
                        prod.imprimir();
                        Console.ReadKey();

                    break;
                    case 2:
                        Console.Clear();
                        for(i=0; i<8; i++)
                        {
                            Console.WriteLine("Quedan {0} productos de {1}",existencia[i], nombre[i]);                       
                        }
                        Console.ReadKey();
                    break;
                    case 3:
                    break;
                }
            }while(opcion!=3);
            Console.ReadKey();
            
        }
    }  
    
}

