// See https://aka.ms/new-console-template for more information
// S4_Flores_Hector
using System;

int opcion = 0;
bool continuar = true;


while (continuar)
{
    //Ingreso de opcion
    bool opcionCorrecta = false;
    while (!opcionCorrecta)
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Supervisado - Hector Flores - 1199923");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("MENU");
        Console.WriteLine("1. Meses del año");
        Console.WriteLine("2. Encontrar el numero mayor");
        Console.WriteLine("3. Signos del zodiaco");
        Console.WriteLine("4. Salir");
        Console.WriteLine("Ingrese una opcion del menu");

        try
        {
            opcion = int.Parse(Console.ReadLine());

            if (opcion > 0 && opcion <= 4)
            {
                opcionCorrecta= true ;
            }

        }
        catch (Exception)
        {

            Console.WriteLine("No debe ingresar letras o decimales");
            Console.ReadKey();
        }
       Console.Clear();
                switch (opcion)
        {
            case 1:
                Console.WriteLine("Ejercicio 1");
                int mes = 0;
                bool rmes = false;
                while(!rmes)
                {
                    try
                    {
                        Console.WriteLine("Ingrese el num. del mes que desee ");
                        mes = int.Parse(Console.ReadLine());
                   
                    
                    rmes = true;
                    if (mes > 0 && mes <= 12)
                    {

                        switch (mes)
                        {
                            case 1:
                                Console.WriteLine("El mes es: Enero");
                                break;
                            case 2:
                                Console.WriteLine("El mes es: Febrero");
                                break;
                            case 3:
                                Console.WriteLine("El mes es: Marzo");
                                break;
                            case 4:
                                Console.WriteLine("El mes es: Abril");
                                break;
                            case 5:
                                Console.WriteLine("El mes es: Mayo");
                                break;
                            case 6:
                                Console.WriteLine("El mes es: Junio");
                                break;
                            case 7:
                                Console.WriteLine("El mes es: Julio");
                                break;
                            case 8:
                                Console.WriteLine("El mes es: Agosto");
                                break;
                            case 9:
                                Console.WriteLine("El mes es: Septiembre");
                                break;
                            case 10:
                                Console.WriteLine("El mes es: Octubre");
                                break;
                            case 11:
                                Console.WriteLine("El mes es: Noviembre");
                                break;
                            case 12:
                                Console.WriteLine("El mes es: Diciembre");
                                break;

                                rmes = true;
                                
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un numero valido, porfavor");
                         rmes = false;

                    }                        
                     } catch (Exception)
                    {
                        Console.WriteLine("No debe ingresar letras o decimales, y debe ingresar un numero");
                        
                    }

                } 

                Console.ReadKey();
                Console.Clear();
                break;
             case 2:
                { 
                Console.WriteLine("Ejercicio 2");
                //variables
                double a = 0;
                double b = 0;
                double c = 0;
                //bucles si no ingresan un numero valido
                bool na = false;
                          
                    try
                    {
                    while (!na)
                    {
                        Console.WriteLine("Ingrese un numero A ");
                        a = Convert.ToDouble(Console.ReadLine());
                        if (a > 0)
                        {
                            na = true;
                            Console.Clear();
                        }
                        else if (a <= 0)
                        {
                            Console.WriteLine("Ingrese un numero mayor que 0");

                            na = false;
                            Console.ReadKey();
                            Console.Clear();
                        }
                       
                    }
                        bool nb = false;
                        while (!nb)
                        {
                            Console.WriteLine("Ingrese un numero B ");
                            b = Convert.ToDouble(Console.ReadLine());

                            if (b > 0)
                            {
                                nb = true;
                            Console.Clear();
                        }
                            else if (b <= 0)
                            {
                                Console.WriteLine("Ingrese un numero mayor que 0");

                                nb = false;
                              Console.ReadKey();
                               Console.Clear();
                            }
                       

                    }
                        bool nc = false;
                        while (!nc)
                        {
                            Console.WriteLine("Ingrese un numero C ");
                            c = Convert.ToDouble(Console.ReadLine());

                            if (c > 0)
                            {
                                nc = true;
                            Console.Clear();
                        }
                            else if (c <= 0)
                            {
                                Console.WriteLine("Ingrese un numero valido");

                                nc = false;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        
                    }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("No ingrese letras y no deje la casilla en blanco");
                        Console.ReadKey();Console.Clear();
                    }
                // Diagrama de flujo de mayor o igual que
                //Si a es mayor que b
                if (a > b)
                {
                        // y a es mayor que c, entonces
                    if (a > c)
                    {
                        Console.WriteLine("El numero mayor de los tres numeros es: " + a);

                        Console.WriteLine("Fin del ejercicio");
                        Console.ReadKey(); 
                     // si  a no es mayor que c pero es igual, entonces
                    } else if (a == c)
                    {
                        Console.WriteLine("El numero mayor es: " + a);
                        Console.WriteLine("Fin del ejercicio");
                        Console.ReadKey();
                    }
                        // si  a no es mayor que c y no es igual, entonces
                        else
                        {
                        Console.WriteLine("El numero mayor de los tres numeros es: " + c);
                        Console.WriteLine("Fin del ejercicio");
                        Console.ReadKey();
                    }  //si a no es mayor que b y es igual a b
                }else if (a == b)
                    { //si a es igual c, entonces
                        if (a > c)
                        {
                            Console.WriteLine("El numero mayor es: " + a);
                            Console.WriteLine("Fin del ejercicio");
                            Console.ReadKey();
                            //si a no es mayor que c pero si es igual, entonces
                        }else if (a == c) 
                        {
                            Console.WriteLine("Todos los numeros son iguales");
                            Console.WriteLine("Fin del ejercicio");
                            Console.ReadKey();

                        }//si a es igual a b, y a no es mayor que c
                        else
                        {
                            Console.WriteLine("El numero mayor de los tres numeros es: " + c);
                            Console.WriteLine("Fin del ejercicio");
                            Console.ReadKey();
                        }
                    // si a no es mayor que B, y b es mayor que c,entonces
                    }else if (b > c) 
                    {
                        Console.WriteLine("El numero mayor de los tres numeros es: " + b);
                        Console.WriteLine("Fin del ejercicio");
                        Console.ReadKey();
                        // si a no es mayor que b y b es igual a c, entonces
                    }   else if(b == c) 
                        {
                        Console.WriteLine("El numero mayor es: " + b);
                        Console.WriteLine("Fin del ejercicio");
                        Console.ReadKey();
                        }//si a no es mayor que b y b no es mayor o igual a c, entonces
                        else
                        {
                        Console.WriteLine("El numero mayor de los tres numeros es: " + c);
                        Console.WriteLine("Fin del ejercicio");
                        Console.ReadKey();
                         }
                                  
                }
          
                Console.ReadKey();
                break;
             case 3:
                Console.WriteLine("Aqui va el ejercicio 3");
                Console.ReadKey();
                break;
             case 4:;
                continuar= false ;
                break;
        }
        Console.Clear();
       
    }

  

}