using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }
    
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNode()/*Method untuk menambahkan sebuah Node kedalam list*/
        {
            int nim;
            string nm;
            Console.Write("\nMasukkan nomer Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nmasukkan nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;

            if (START == null || nim <= START.noMhs) /*Node ditambahkankan sebagai nodeBaru*/
            {
                if((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine(("\nNomer mahasiswa tidak diijinkan\n"));
                    return;
                }
                nodeBaru.next = START;
                START = nodeBaru;
                return;
            }
            /*menemukan lokasi node baru didalam list*/
            Node previous, current;
            previous = START;
            current = START;

            while((current != null) && (nim >= current.noMhs))
            {
                if(nim == current.noMhs)
                {
                    Console
                }
            }
        }
    }
}
