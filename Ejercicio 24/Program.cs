using System;

namespace Definitivo_24
{
    class Program
    {
        enum estados { Inactivo, Reproduciendo, Pausado, Parado, Cerrado }

        static void Main(string[] args)
        {
            estados estado = estados.Inactivo;

            
            char accion = ' ';

            do
            {

                try
                {
                    Console.WriteLine($"El estado actual del reproductor es: {estado}");
                    Console.WriteLine("\nIntroduce una acción ( p, s, q ): ");
                    accion = char.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (accion)
                    {
                        case 'p':

                            try
                            {
                                if (estado == estados.Parado)
                                {
                                    throw new Exception();
                                }
                                else if (estado == estados.Inactivo)
                                {
                                    estado = estados.Reproduciendo;
                                }
                                else if (estado == estados.Reproduciendo)
                                {
                                    estado = estados.Pausado;
                                }
                                else if (estado == estados.Pausado)
                                {
                                    estado = estados.Reproduciendo;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("La acción que ha introducido no existe");
                                Console.WriteLine("");
                            }
                            
                            break;

                        case 's':

                            try
                            {
                                if (estado == estados.Inactivo || estado == estados.Parado)
                                {
                                    throw new Exception();
                                }
                                else if (estado == estados.Reproduciendo || estado == estados.Pausado)
                                {
                                    estado = estados.Parado;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("La acción que ha introducido no existe");
                                Console.WriteLine("");
                            }

                            break;

                        case 'q':
                            estado = estados.Cerrado;
                            break;

                        default:
                            throw new Exception();
                            break;
                    }
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("La acción que ha introducido no existe");
                    Console.WriteLine("");
                }

            } while (estado != estados.Cerrado);

        }
    }
}