using System;

namespace SdoParcial
{
    class Productos
    {
        public string nombreP;
        public int cantidadP;
        public int precioP;
        public int cantidadV;

        public Productos(string nombrePR, int cantidadPR, int precioPR, int cantidadVR)
        {
            nombreP = nombrePR;
            cantidadP = cantidadPR;
            precioP = precioPR;
            cantidadV = cantidadVR;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Productos Agua = new Productos("Botella de Agua", 10, 15, 0);
            Productos Refresco01 = new Productos("Coca Cola", 10, 25, 0);
            Productos Refresco02 = new Productos("Pepsi", 10, 20, 0);
            Productos Refresco03 = new Productos("Kola Real", 10, 15, 0);
            Productos Jugo01 = new Productos("Jugo de Frutas Santal Pequeño", 10, 15, 0);
            Productos Jugo02 = new Productos("Jugo de Manzana Santal Pequeño", 10, 15, 0);
            Productos Jugo03 = new Productos("Jugo de Naranja Santal Pequeño", 10, 15, 0);
            Productos Galleta01 = new Productos("Galleta Mamut", 10, 15, 0);
            Productos Galleta02 = new Productos("Galleta Ritz Normal", 10, 10, 0);
            Productos Galleta03 = new Productos("Galleta Ritz de Queso", 10, 15, 0);
            int Selec1;
            do
            {
                Console.WriteLine("Bienvenido/a, seleccione la opcion que desea utilizar:");
                Console.WriteLine("1 - Comprar un producto. \n2 - Ver informe de ventas. \n3 - Salir.");
                Selec1 = Convert.ToInt32(Console.ReadLine());
                switch (Selec1)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Seleccione el producto que desea comprar:");
                        Console.WriteLine("1 - " + Agua.nombreP + " // Precio: " + Agua.precioP + "\n2 - " + Refresco01.nombreP + " // Precio: " + Refresco01.precioP + "\n3 - " + Refresco02.nombreP
                            + " // Precio: " + Refresco02.precioP + "\n4 - " + Refresco03.nombreP + " // Precio: " + Refresco03.precioP +
                            "\n5 - " + Jugo01.nombreP + " // Precio: " + Jugo01.precioP + "\n6 - " + Jugo02.nombreP + " // Precio: " + Jugo02.precioP + "\n7 - " + Jugo03.nombreP + " // Precio: " + Jugo03.precioP + "\n8 - "
                            + Galleta01.nombreP + " // Precio: " + Galleta01.precioP + "\n9 - " + Galleta02.nombreP
                            + " // Precio: " + Galleta02.precioP + "\n10 - " + Galleta03.nombreP + " // Precio: " + Galleta03.precioP);
                        byte Selec2 = Convert.ToByte(Console.ReadLine());
                        switch (Selec2)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Agua.nombreP);
                                Console.WriteLine("Monto a pagar: " + Agua.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec3 = Convert.ToByte(Console.ReadLine());
                                switch (Selec3)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Agua.precioP)
                                        {
                                            Agua.cantidadP--;
                                            Agua.cantidadV++;
                                            int devuelta = DT - Agua.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Agua.precioP)
                                        {
                                            Agua.cantidadP--;
                                            Agua.cantidadV++;
                                            int devuelta = DT1 - Agua.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Agua.precioP)
                                        {
                                            Agua.cantidadP--;
                                            Agua.cantidadV++;
                                            int devuelta = DT2 - Agua.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Agua.precioP)
                                        {
                                            Agua.cantidadP--;
                                            Agua.cantidadV++;
                                            int devuelta = DT3 - Agua.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Agua.precioP)
                                        {
                                            Agua.cantidadP--;
                                            Agua.cantidadV++;
                                            int devuelta = DT4 - Agua.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Agua.precioP)
                                        {
                                            Agua.cantidadP--;
                                            Agua.cantidadV++;
                                            int devuelta = DT5 - Agua.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Refresco01.nombreP);
                                Console.WriteLine("Monto a pagar: " + Refresco01.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec4 = Convert.ToByte(Console.ReadLine());
                                switch (Selec4)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Refresco01.precioP)
                                        {
                                            Refresco01.cantidadP--;
                                            Refresco01.cantidadV++;
                                            int devuelta = DT - Refresco01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Refresco01.precioP)
                                        {
                                            Refresco01.cantidadP--;
                                            Refresco01.cantidadV++;
                                            int devuelta = DT1 - Refresco01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Refresco01.precioP)
                                        {
                                            Refresco01.cantidadP--;
                                            Refresco01.cantidadV++;
                                            int devuelta = DT2 - Refresco01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Refresco01.precioP)
                                        {
                                            Refresco01.cantidadP--;
                                            Refresco01.cantidadV++;
                                            int devuelta = DT3 - Refresco01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Refresco01.precioP)
                                        {
                                            Refresco01.cantidadP--;
                                            Refresco01.cantidadV++;
                                            int devuelta = DT4 - Refresco01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Refresco01.precioP)
                                        {
                                            Refresco01.cantidadP--;
                                            Refresco01.cantidadV++;
                                            int devuelta = DT5 - Refresco01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Refresco02.nombreP);
                                Console.WriteLine("Monto a pagar: " + Refresco02.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec5 = Convert.ToByte(Console.ReadLine());
                                switch (Selec5)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Refresco02.precioP)
                                        {
                                            Refresco02.cantidadP--;
                                            Refresco02.cantidadV++;
                                            int devuelta = DT - Refresco02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Refresco02.precioP)
                                        {
                                            Refresco02.cantidadP--;
                                            Refresco02.cantidadV++;
                                            int devuelta = DT1 - Refresco02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Refresco02.precioP)
                                        {
                                            Refresco02.cantidadP--;
                                            Refresco02.cantidadV++;
                                            int devuelta = DT2 - Refresco02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Refresco02.precioP)
                                        {
                                            Refresco02.cantidadP--;
                                            Refresco02.cantidadV++;
                                            int devuelta = DT3 - Refresco02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Refresco02.precioP)
                                        {
                                            Refresco02.cantidadP--;
                                            Refresco02.cantidadV++;
                                            int devuelta = DT4 - Refresco02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Refresco02.precioP)
                                        {
                                            Refresco02.cantidadP--;
                                            Refresco02.cantidadV++;
                                            int devuelta = DT5 - Refresco02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;

                            case 4:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Refresco03.nombreP);
                                Console.WriteLine("Monto a pagar: " + Refresco03.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec6 = Convert.ToByte(Console.ReadLine());
                                switch (Selec6)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Refresco03.precioP)
                                        {
                                            Refresco03.cantidadP--;
                                            Refresco03.cantidadV++;
                                            int devuelta = DT - Refresco03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Refresco03.precioP)
                                        {
                                            Refresco03.cantidadP--;
                                            Refresco03.cantidadV++;
                                            int devuelta = DT1 - Refresco03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Refresco03.precioP)
                                        {
                                            Refresco03.cantidadP--;
                                            Refresco03.cantidadV++;
                                            int devuelta = DT2 - Refresco03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Refresco03.precioP)
                                        {
                                            Refresco03.cantidadP--;
                                            Refresco03.cantidadV++;
                                            int devuelta = DT3 - Refresco03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Refresco03.precioP)
                                        {
                                            Refresco03.cantidadP--;
                                            Refresco03.cantidadV++;
                                            int devuelta = DT4 - Refresco03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Refresco03.precioP)
                                        {
                                            Refresco03.cantidadP--;
                                            Refresco03.cantidadV++;
                                            int devuelta = DT5 - Refresco03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;

                            case 5:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Jugo01.nombreP);
                                Console.WriteLine("Monto a pagar: " + Jugo01.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec7 = Convert.ToByte(Console.ReadLine());
                                switch (Selec7)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Jugo01.precioP)
                                        {
                                            Jugo01.cantidadP--;
                                            Jugo01.cantidadV++;
                                            int devuelta = DT - Jugo01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Jugo01.precioP)
                                        {
                                            Jugo01.cantidadP--;
                                            Jugo01.cantidadV++;
                                            int devuelta = DT1 - Jugo01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Jugo01.precioP)
                                        {
                                            Jugo01.cantidadP--;
                                            Jugo01.cantidadV++;
                                            int devuelta = DT2 - Jugo01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Jugo01.precioP)
                                        {
                                            Jugo01.cantidadP--;
                                            Jugo01.cantidadV++;
                                            int devuelta = DT3 - Jugo01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Jugo01.precioP)
                                        {
                                            Jugo01.cantidadP--;
                                            Jugo01.cantidadV++;
                                            int devuelta = DT4 - Jugo01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Jugo01.precioP)
                                        {
                                            Jugo01.cantidadP--;
                                            Jugo01.cantidadV++;
                                            int devuelta = DT5 - Jugo01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;

                            case 6:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Jugo02.nombreP);
                                Console.WriteLine("Monto a pagar: " + Jugo02.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec8 = Convert.ToByte(Console.ReadLine());
                                switch (Selec8)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Jugo02.precioP)
                                        {
                                            Jugo02.cantidadP--;
                                            Jugo02.cantidadV++;
                                            int devuelta = DT - Jugo02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Jugo02.precioP)
                                        {
                                            Jugo02.cantidadP--;
                                            Jugo02.cantidadV++;
                                            int devuelta = DT1 - Jugo02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Jugo02.precioP)
                                        {
                                            Jugo02.cantidadP--;
                                            Jugo02.cantidadV++;
                                            int devuelta = DT2 - Jugo02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Jugo02.precioP)
                                        {
                                            Jugo02.cantidadP--;
                                            Jugo02.cantidadV++;
                                            int devuelta = DT3 - Jugo02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Jugo02.precioP)
                                        {
                                            Jugo02.cantidadP--;
                                            Jugo02.cantidadV++;
                                            int devuelta = DT4 - Jugo02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Jugo02.precioP)
                                        {
                                            Jugo02.cantidadP--;
                                            Jugo02.cantidadV++;
                                            int devuelta = DT5 - Jugo02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;

                            case 7:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Jugo03.nombreP);
                                Console.WriteLine("Monto a pagar: " + Jugo03.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec9 = Convert.ToByte(Console.ReadLine());
                                switch (Selec9)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Jugo03.precioP)
                                        {
                                            Jugo03.cantidadP--;
                                            Jugo03.cantidadV++;
                                            int devuelta = DT - Jugo03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Jugo03.precioP)
                                        {
                                            Jugo03.cantidadP--;
                                            Jugo03.cantidadV++;
                                            int devuelta = DT1 - Jugo03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Jugo03.precioP)
                                        {
                                            Jugo03.cantidadP--;
                                            Jugo03.cantidadV++;
                                            int devuelta = DT2 - Jugo03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Jugo03.precioP)
                                        {
                                            Jugo03.cantidadP--;
                                            Jugo03.cantidadV++;
                                            int devuelta = DT3 - Jugo03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Jugo03.precioP)
                                        {
                                            Jugo03.cantidadP--;
                                            Jugo03.cantidadV++;
                                            int devuelta = DT4 - Jugo03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Jugo03.precioP)
                                        {
                                            Jugo03.cantidadP--;
                                            Jugo03.cantidadV++;
                                            int devuelta = DT5 - Jugo03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;

                            case 8:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Galleta01.nombreP);
                                Console.WriteLine("Monto a pagar: " + Galleta01.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec10 = Convert.ToByte(Console.ReadLine());
                                switch (Selec10)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Galleta01.precioP)
                                        {
                                            Galleta01.cantidadP--;
                                            Galleta01.cantidadV++;
                                            int devuelta = DT - Galleta01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Galleta01.precioP)
                                        {
                                            Galleta01.cantidadP--;
                                            Galleta01.cantidadV++;
                                            int devuelta = DT1 - Galleta01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Galleta01.precioP)
                                        {
                                            Galleta01.cantidadP--;
                                            Galleta01.cantidadV++;
                                            int devuelta = DT2 - Galleta01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Galleta01.precioP)
                                        {
                                            Galleta01.cantidadP--;
                                            Galleta01.cantidadV++;
                                            int devuelta = DT3 - Galleta01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Galleta01.precioP)
                                        {
                                            Galleta01.cantidadP--;
                                            Galleta01.cantidadV++;
                                            int devuelta = DT4 - Galleta01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Galleta01.precioP)
                                        {
                                            Galleta01.cantidadP--;
                                            Galleta01.cantidadV++;
                                            int devuelta = DT5 - Galleta01.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;

                            case 9:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Galleta02.nombreP);
                                Console.WriteLine("Monto a pagar: " + Galleta02.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec11 = Convert.ToByte(Console.ReadLine());
                                switch (Selec11)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Galleta02.precioP)
                                        {
                                            Galleta02.cantidadP--;
                                            Galleta02.cantidadV++;
                                            int devuelta = DT - Galleta02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Galleta02.precioP)
                                        {
                                            Galleta02.cantidadP--;
                                            Galleta02.cantidadV++;
                                            int devuelta = DT1 - Galleta02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Galleta02.precioP)
                                        {
                                            Galleta02.cantidadP--;
                                            Galleta02.cantidadV++;
                                            int devuelta = DT2 - Galleta02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Galleta02.precioP)
                                        {
                                            Galleta02.cantidadP--;
                                            Galleta02.cantidadV++;
                                            int devuelta = DT3 - Galleta02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Galleta02.precioP)
                                        {
                                            Galleta02.cantidadP--;
                                            Galleta02.cantidadV++;
                                            int devuelta = DT4 - Galleta02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Galleta02.precioP)
                                        {
                                            Galleta02.cantidadP--;
                                            Galleta02.cantidadV++;
                                            int devuelta = DT5 - Galleta02.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;

                            case 10:
                                Console.Clear();
                                Console.WriteLine("Producto seleccionado: " + Galleta03.nombreP);
                                Console.WriteLine("Monto a pagar: " + Galleta03.precioP);
                                Console.WriteLine("Seleccione el tipo de moneda que desee utilizar: \n1 - Monedas de 5 Pesos. \n2 - Monedas de 10 Pesos." +
                                    "\n3 - Monedas de 25 Pesos. \n4 - Billetes de 50 Pesos. \n5 - Billetes de 100 Pesos. \n6 - Billetes de 200 Pesos.");
                                byte Selec12 = Convert.ToByte(Console.ReadLine());
                                switch (Selec12)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM = Convert.ToByte(Console.ReadLine());
                                        int DT = CantM * 5;
                                        if (DT >= Galleta03.precioP)
                                        {
                                            Galleta03.cantidadP--;
                                            Galleta03.cantidadV++;
                                            int devuelta = DT - Galleta03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM1 = Convert.ToByte(Console.ReadLine());
                                        int DT1 = CantM1 * 10;
                                        if (DT1 >= Galleta03.precioP)
                                        {
                                            Galleta03.cantidadP--;
                                            Galleta03.cantidadV++;
                                            int devuelta = DT1 - Galleta03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 3:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM2 = Convert.ToByte(Console.ReadLine());
                                        int DT2 = CantM2 * 25;
                                        if (DT2 >= Galleta03.precioP)
                                        {
                                            Galleta03.cantidadP--;
                                            Galleta03.cantidadV++;
                                            int devuelta = DT2 - Galleta03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 4:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM3 = Convert.ToByte(Console.ReadLine());
                                        int DT3 = CantM3 * 50;
                                        if (DT3 >= Galleta03.precioP)
                                        {
                                            Galleta03.cantidadP--;
                                            Galleta03.cantidadV++;
                                            int devuelta = DT3 - Galleta03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 5:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM4 = Convert.ToByte(Console.ReadLine());
                                        int DT4 = CantM4 * 100;
                                        if (DT4 >= Galleta03.precioP)
                                        {
                                            Galleta03.cantidadP--;
                                            Galleta03.cantidadV++;
                                            int devuelta = DT4 - Galleta03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;
                                    case 6:

                                        Console.Clear();
                                        Console.WriteLine("Cantidad que desea introducir: ");
                                        byte CantM5 = Convert.ToByte(Console.ReadLine());
                                        int DT5 = CantM5 * 200;
                                        if (DT5 >= Galleta03.precioP)
                                        {
                                            Galleta03.cantidadP--;
                                            Galleta03.cantidadV++;
                                            int devuelta = DT5 - Galleta03.precioP;
                                            Console.Clear();
                                            Console.WriteLine("Compra realizada exitosamente. Su devuelta es de: " + devuelta);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("No ingreso el monto necesario para realizar la compra.");
                                        }
                                        break;

                                }
                                break;
                        }
                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("Informe de Ventas.");
                        Console.WriteLine("Productos vendidos: ");
                        Console.WriteLine(Agua.nombreP + " = " + Agua.cantidadV);
                        Console.WriteLine(Refresco01.nombreP + " = " + Refresco01.cantidadV);
                        Console.WriteLine(Refresco02.nombreP + " = " + Refresco02.cantidadV);
                        Console.WriteLine(Refresco03.nombreP + " = " + Refresco03.cantidadV);
                        Console.WriteLine(Jugo01.nombreP + " = " + Jugo01.cantidadV);
                        Console.WriteLine(Jugo02.nombreP + " = " + Jugo02.cantidadV);
                        Console.WriteLine(Jugo03.nombreP + " = " + Jugo03.cantidadV);
                        Console.WriteLine(Galleta01.nombreP + " = " + Galleta01.cantidadV);
                        Console.WriteLine(Galleta02.nombreP + " = " + Galleta02.cantidadV);
                        Console.WriteLine(Galleta03.nombreP + " = " + Galleta03.cantidadV);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Productos Restantes: ");
                        Console.WriteLine(Agua.nombreP + " = " + Agua.cantidadP);
                        Console.WriteLine(Refresco01.nombreP + " = " + Refresco01.cantidadP);
                        Console.WriteLine(Refresco02.nombreP + " = " + Refresco02.cantidadP);
                        Console.WriteLine(Refresco03.nombreP + " = " + Refresco03.cantidadP);
                        Console.WriteLine(Jugo01.nombreP + " = " + Jugo01.cantidadP);
                        Console.WriteLine(Jugo02.nombreP + " = " + Jugo02.cantidadP);
                        Console.WriteLine(Jugo03.nombreP + " = " + Jugo03.cantidadP);
                        Console.WriteLine(Galleta01.nombreP + " = " + Galleta01.cantidadP);
                        Console.WriteLine(Galleta02.nombreP + " = " + Galleta02.cantidadP);
                        Console.WriteLine(Galleta03.nombreP + " = " + Galleta03.cantidadP);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (Selec1 != 3 && Selec1 < 3);

        }
    }
}
