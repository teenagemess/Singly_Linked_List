using System;
using System.Collections.Generic;
using System.IO;
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
                    Console.WriteLine("\nNomer mahasiswa sama tidak diijinkan\n");
                    return;
                }
                previous = current;
                current = current.next;
            }
            /*Node baru akan ditempatkan diantara previus dan current*/

            nodeBaru.next = current;
            previous.next = nodeBaru;
        }
        /*Method untuk menghapus node tertentu didalam list*/
        public bool delnode(int nim)
        {
            Node previous, current;
            previous = current = null;
            /*check apakah node yang dimaksud ada di dalam list atau tidak*/
            if(Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }

        /*Method untuk mengecheck apakah node yang dimaksud ada didalam list*/
        public bool Search(int nim,ref Node previous, ref Node current)
        {
            previous = START;
            current = START;

            while((current != null) && (nim != current.noMhs))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return (true);
        }

        //Method untuk Traverse/mengunjungi dan membaca isi list
        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList kosong. \n");
            else
            {
                Console.WriteLine("\nData didalam list adalah : \n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.WriteLine(currentNode.noMhs + " " + currentNode.nama + "\n");
                Console.WriteLine();
            }
        }
        
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
    }
}
