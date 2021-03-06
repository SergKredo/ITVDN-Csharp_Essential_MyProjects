﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class TXTHandler: AbstractHandler
    {
        string typeDocument = "TXT";
        string functional;
        public override string TypeDocument 
        {
            get
            {
                if (string.IsNullOrEmpty(typeDocument))
                { 
                    return "Вы не ввели или выбрали неправильный тип документа!"; 
                }
                else { 
                    return typeDocument;
                }
            }
            set
            {
                typeDocument = value;
            }
        }
        public override string Functional
        {
            get
            {
                if (string.IsNullOrEmpty(functional))
                {
                    return "Вы не ввели или выбрали неправильный функционал документа!";
                }
                else
                {
                    return functional;
                }
            }
            set
            {
                functional = value;
            }
        }
        public override void Open()
        {
            Console.WriteLine("Вы выбрали функцию - открыть документ TXT формата.");
        }
        public override void Create()
        {
            Console.WriteLine("Вы выбрали функцию - создать документ TXT формата.");
        }
        public override void Change()
        {
            Console.WriteLine("Вы выбрали функцию - изменить документ TXT формата.");
        }
        public override void Save()
        {
            Console.WriteLine("Вы выбрали функцию - сохранить документ TXT формата.");
        }
    }
}
