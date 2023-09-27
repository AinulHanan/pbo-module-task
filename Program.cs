using System;

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop " + merk + " " + tipe + " menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop " + merk + " " + tipe + " mati");
    }
}

class ASUS : Laptop
{
    public ASUS()
    {
        merk = "ASUS";
    }
}

class Vivobook : ASUS
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ROG : ASUS
{
    public ROG()
    {
        tipe = "ROG";
    }
}
class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}
class ACER : Laptop
{
    public ACER()
    {
        merk = "ACER";
    }
}

class Swift : ACER
{
    public Swift()
    {
        tipe = "Swift";
    }
}

class Predator : ACER
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine("Laptop " + merk + " " + tipe + " sedang memainkan game");
    }
}

class Vga
{
    public string merk;
}

class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}

class AMDV : Vga
{
    public AMDV()
    {
        merk = "AMD";
    }
}

class Processor
{
    public string merk;
    public string tipe;
}

class Intel : Processor
{
    public Intel()
    {
        merk = "Intel";
    }
}

class CoreI3 : Intel
{
    public CoreI3()
    {
        tipe = "CoreI3";
    }
}
class CoreI5 : Intel
{
    public CoreI5()
    {
        tipe = "CoreI5";
    }
}
class CoreI7 : Intel
{
    public CoreI7()
    {
        tipe = "CoreI7";
    }
}
class AMD : Processor
{
    public AMD()
    {
        merk = "AMD";
    }
}
class Ryzen : AMD
{
    public Ryzen()
    {
        tipe = "Ryzen";
    }
}
class ATHLON : AMD
{
    public ATHLON()
    {
        tipe = "ATHLON";
    }
}

class Task
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Jawaban Soal 1");
        Laptop laptop2 = new Predator();
        laptop2.vga = new AMDV();
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        Console.WriteLine("");

        Console.WriteLine("Jawaban Soal 2");
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        //laptop1.Ngoding(); error karena method ini tidak dipunyai di class induk atau class mobil
        Console.WriteLine("");

        Console.WriteLine("Jawaban Soal 3");
        Console.WriteLine("Spesifikasi laptop1:");

        // Inisialisasi objek Vga dan Processor untuk laptop1
        laptop1.vga = new Nvidia(); // Misalnya, sesuaikan dengan kebutuhan
        laptop1.processor = new CoreI5(); // Misalnya, sesuaikan dengan kebutuhan

        Console.WriteLine($"Merk VGA: {laptop1.vga.merk}");
        Console.WriteLine($"Merk Processor: {laptop1.processor.merk}");
        Console.WriteLine($"Tipe Processor: {laptop1.processor.tipe}");
        Console.WriteLine("");

        Console.WriteLine("Jawaban Soal 4");
        Predator predator1 = new Predator();
        predator1.vga = new AMDV();
        predator1.BermainGame();
        Console.WriteLine("");

        Console.WriteLine("Jawaban Soal 5");
        //acer.BermainGame(); error karena class induk tidak bisa mengakses method class turunan
        ACER acer = new Predator();

        // Jalankan method BermainGame() pada acer
        (acer as Predator).BermainGame();//Solusinya menggunakan operator as untuk pengecekan acer adalah objek dari tipe predator
    }
}