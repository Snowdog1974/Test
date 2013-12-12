using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace A_net
{
    public class ToDoListM : ObservableCollection<ToDos>  //AttGöraLista alla
    {
        public ToDoListM()
            : base()
        {
            Add(new ToDos(false, true, false, "2006", "K200", "Artikel K200", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2010", "K305", "Artikel K305", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2010", "K300", "Artikel K300", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2001", "K503", "Artikel K503", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2003", "K507", "Artikel K507", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2007", "K523", "Artikel K523", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2007", "K513", "Artikel K513", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(true, false, false, "853", "K100", "Artikel K100", "Inköp", "2010-10-26", null, null, "Ej inlevererad"));
            Add(new ToDos(true, false, false, "1000", "E101", "Artikel E101", "Tillverkning", "2010-42-1", null, null, "Ej avbokad"));
            Add(new ToDos(true, false, false, "1645", "E523", "Artikel E523", "Terminal", "2010-11-10", "152", null, "Olle ej instämplad"));
            Add(new ToDos(false, true, false, "5532", null, "Prototyp Axel", "Förkalkyl", "2010-11-06", null, null, "Ej fått svar på offert"));
            Add(new ToDos(false, true, false, "5540", null, "Prototyp Verktyg", "Förkalkyl", "2010-11-09", null, null, "Ej fått svar på offert"));
            Add(new ToDos(false, true, false, "1152", "E110", "Artikel E110", "Tillverkning", "2010-47-1", null, "50", "Svarv CNC står still"));
            Add(new ToDos(true, false, false, "1152", "E200", "Axel Komplett", "Tillverkning", "2010-49-1", null, "50", "Stopp på underliggande order"));
            Add(new ToDos(true, false, false, "860", "K205", "Artikel K205", "Inköp", "2010-10-26", null, null, " Ej inlevererad"));
            Add(new ToDos(true, false, false, "875", "K300", "Artikel K300", "Inköp", "2010-10-27", null, null, "Ej skickat"));
            Add(new ToDos(true, false, false, "880", "K500", "Artikel K500", "Inköp", "2010-11-10", null, null, " Ej inlevererad"));
            Add(new ToDos(true, false, false, "881", "K501", "Artikel K501", "Inköp", "2010-11-10", null, null, " Ej inlevererad"));
            Add(new ToDos(true, false, false, "882", "K502", "Artikel K502", "Inköp", "2010-11-10", null, null, " Ej inlevererad"));
            Add(new ToDos(true, false, false, "883", "K503", "Artikel K503", "Inköp", "2010-11-10", null, null, " Ej inlevererad"));

        }
    }


    public class ToDoList2 : ObservableCollection<ToDos>
    {
        public ToDoList2()
            : base()
        {
            Add(new ToDos(false, false, true, "853", "K100", "Artikel K100", "Inköp", "2010-08-02", null, null, " Ej inlevererad"));
            Add(new ToDos(true, false, false, "0001", "E101", "Artikel E101", "Tillverkning", "2010-08-11", null, null, "Ej inlevererad"));
            Add(new ToDos(true, false, false, "5461", "E523", "Artikel E523", "Terminal", "2010-08-31", "152", null, " Ej inlevererad"));
            Add(new ToDos(true, true, false, "2355", null, "Prototyp Axel", "Förkalkyl", "2010-08-12", null, null, " Ej inlevererad"));
            Add(new ToDos(false, true, false, "5540", null, "Prototyp Verktyg", "Förkalkyl", "2010-10-13", null, null, " Ej inlevererad"));
            Add(new ToDos(false, true, false, "2511", "E110", "Artikel E110", "Tillverkning", "2010-09-15", null, "50", " Ej inlevererad"));
            Add(new ToDos(true, false, false, "2511", "E200", "Axel Komplett", "Tillverkning", "2010-09-30", null, "50", " Ej inlevererad"));
        }
    }

    public class ToDoListOffer : ObservableCollection<ToDos> //Attgöralista förkalkyl
    {
        public ToDoListOffer()
            : base()
        {
            Add(new ToDos(false, true, false, "5532", null, "Prototyp Axel", "Förkalkyl", "2010-11-06", null, null, "Ej fått svar på offert"));
            Add(new ToDos(false, true, false, "5540", null, "Prototyp Verktyg", "Förkalkyl", "2010-11-09", null, null, "Ej fått svar på offert"));
        }
    }

    public class ToDoListProd : ObservableCollection<ToDos> //AttGöraLista Tillverkningsorder
    {
        public ToDoListProd() 
            : base()
        {
            Add(new ToDos(true, false, false, "1000", "E101", "Artikel E101", "Tillverkning", "2010-42-1", null, null, "Ej avbokad"));
            Add(new ToDos(false, true, false, "2511", "E110", "Artikel E110", "Tillverkning", "2010-47-1", null, "50", "Svarv CNC står still"));
            Add(new ToDos(true, false, false, "2511", "E200", "Axel Komplett", "Tillverkning", "2010-49-1", null, "50", "Stopp på underliggande order"));
        }
    }
    
    public class ToDoListMaterial : ObservableCollection<ToDos> //AttGöralista Material
    {
        public ToDoListMaterial()
            : base()
        {
            Add(new ToDos(false, true, false, "2006", "K200", "Artikel K200", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2010", "K305", "Artikel K305", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2010", "K300", "Artikel K300", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2001", "K503", "Artikel K503", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2003", "K507", "Artikel K507", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2007", "K523", "Artikel K523", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(false, true, false, "2007", "K513", "Artikel K513", "Inköp", "", null, null, "Bokad via Tillverkningsorder"));
            Add(new ToDos(true, false, false, "853", "K100", "Artikel K100", "Inköp", "2010-10-26", null, null, "Ej inlevererad"));
            Add(new ToDos(true, false, false, "860", "K205", "Artikel K205", "Inköp", "2010-10-26", null, null, "Ej inlevererad"));
            Add(new ToDos(true, false, false, "875", "K300", "Artikel K300", "Inköp", "2010-10-27", null, null, "Ej skickat"));
            Add(new ToDos(true, false, false, "880", "K500", "Artikel K500", "Inköp", "2010-11-10", null, null, "Ej inlevererad"));
            Add(new ToDos(true, false, false, "881", "K501", "Artikel K501", "Inköp", "2010-11-10", null, null, "Ej inlevererad"));
            Add(new ToDos(true, false, false, "882", "K502", "Artikel K502", "Inköp", "2010-11-10", null, null, "Ej inlevererad"));
            Add(new ToDos(true, false, false, "883", "K503", "Artikel K503", "Inköp", "2010-11-10", null, null, "Ej inlevererad"));
            
            
        }
    }

    public class ToDoListStaff : ObservableCollection<ToDos> //AttGöralista Personal
    {
        public ToDoListStaff()
            : base()
        {
            Add(new ToDos(true, false, false, "5461", "E523", "Artikel E523", "Terminal", "2010-11-10", "152", null, "Olle ej instämplad"));
            
        }
    }


    public class OfferList : ObservableCollection<OfferLi> //Lista Förkalkyl
    {
        public OfferList()
            : base()
	    {
            Add(new OfferLi(1, "5532", null, "Kund", null, "Prototyp Axel", "2010-10-25", "2010-11-16", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, "st", null, false, false, false, false, "Order", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(2, "5533", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-11-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, "st", null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(3, "5534", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-11-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, "st", null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(4, "5535", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-11-15", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, "st", null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(1, "5536", null, "Kund", "E700", "Bord 1000x700", "2010-10-25", "2010-11-25", null, null, null, null,
                    1.00, 1.00, "158392", null, null, "T6545", "Mio Möbler", 3582.25, 0.00, 0.00, "st", null, false, false, false, false, "Order", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(2, "5537", null, "Kund", "E795", "Egenartikel 795", "2010-11-09", "2010-12-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Scania", 5382.25, 0, 0, "st", null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(3, "5538", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-11-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Scania", 9895.25, 0, 0, "st", null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(4, "5539", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-11-15", null, null, null, null,
                    1, 1, null, null, null, "7589", "Trio Plast", 8952.25, 0, 0, "st", null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(1, "5540", null, "Kund", null, "Klädskåp", "2010-10-25", "2010-11-16", null, null, null, null,
                    1.00, 1.00, "158392", null, null, "M765", "Svets & Smide i Arboga", 3582.25, 0.00, 0.00, "st", null, false, false, false, false, "Order", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(2, "5541", null, "Kund", "E567", "Hjulaxel LB", "2010-10-26", "2010-11-21", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, "st", null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(3, "5542", null, "Kund", "E568", "Hjulaxel LB", "2010-10-26", "2010-11-14", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, "st", null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(4, "5543", null, "Kund", null, "Stol", "2010-10-26", "2010-11-25", null, null, null, null,
                    1, 1, null, null, null, "7855", "Snickeriet i Habo", 8952.25, 0, 0, "st", null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
        }
    }

    public class OfferMtrlList : ObservableCollection<OfferMtrl> //Lista Förkalkyl MAterialflik
    {
        public OfferMtrlList()
            :base()
        {
            Add(new OfferMtrl(1, 1, 1, "K100", "Stål 30mm", "543", "Tibnor", 5, "m", 250, 1250, null, null, "A1", "10", "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(2, 1, 2, "K105", "Bricka ", "543", "Tibnor", 2, "st", 15, 30, null, null, "B12", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(3, 1, 3, "E150", "Hållare", null, null, 2, "st", 1500, 3000, null, null, null, "20", "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(4, 2, 1, "K100", "Stål 50mm", "543", "Tibnor", 5, "m", 350, 1750, null, null, "A1", "10", "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(5, 2, 2, "K105", "Bricka", "543", "Tibnor", 4, "m", 15, 60, null, null, "B12", "10", "2010-07-25", "2010-07-25"));
        }
    }

    public class OfferMtrlListEmpty : ObservableCollection<OfferMtrl> //Lista Förkalkyl MAterialflik
    {
        public OfferMtrlListEmpty()
            : base()
        {
            
        }
    }

    public class ProductionList : ObservableCollection<OfferLi> //Tillverkningsorder lista
    {
        public ProductionList()
            : base()
        {
            Add(new OfferLi(1, "2000",null, "Kund", "E101", "Artikel E101", "2010-10-25", "2010-48-5", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(2, "2001", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-47-4", null, null, null, null,
                25, 25, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(3, "2002", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-47-1", null, null, null, null,
                25, 25, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(4, "2003", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-49-5", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(5, "2004",null, "Kund", "E107", "Artikel E101", "2010-10-25", "2010-47-3", null, null, null, null,
                500.00, 500.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(6, "2005", null, "Kund", "E109", "Hjulaxel LB", "2010-10-26", "2010-47-4", null, null, null, null,
                60, 60, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(7, "2006", null, "Kund", "E104", "Hjulaxel LB", "2010-09-26", "2010-48-3", null, null, null, null,
                50, 50, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(8, "2007", null, "Kund", "E586", "Bokhylla Billy Vit", "2010-10-26", "2010-49-4", null, null, null, null,
                    200, 200, null, null, null, "8545", "IKEA", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(9, "2008",null, "Kund", "E587", "Bokhylla Billy Ek", "2010-10-25", "2010-50-2", null, null, null, null,
                100.00, 100.00, "158392", null, null, "8545", "IKEA", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(10, "2010", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-50-3", null, null, null, null,
                5, 5, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(11, "2010", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-51-1", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(12, "2011", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-51-2", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(13, "2012",null, "Kund", "E101", "Artikel E101", "2010-10-25", "2010-48-4", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(14, "2013", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-49-2", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(15, "2014", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-47-5", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(16, "2015", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-47-5", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));  
            Add(new OfferLi(17, "2016",null, "Kund", "E101", "Artikel E101", "2010-10-25", "2010-49-5", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(18, "2017", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-51-2", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(19, "2018", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-51-3", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(20, "2019", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-51-5", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(21, "2020",null, "Kund", "E101", "Artikel E101", "2010-10-25", "2010-51-1", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(22, "2021", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-50-2", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(23, "2022", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-50-5", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(24, "2023", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-50-5", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(25, "2024",null, "Kund", "E101", "Artikel E101", "2010-10-25", "2010-50-3", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(26, "2025", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-50-4", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(27, "2026", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-51-1", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(28, "2027", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-05-1", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(29, "2028",null, "Kund", "E101", "Artikel E101", "2010-10-25", "2010-05-2", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-05-3", "2010-07-25"));
            Add(new OfferLi(30, "2029", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-05-4", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(31, "2030", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-05-5", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(32, "2031", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-05-5", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
        }
    }

    public class QwickOrderList : ObservableCollection<OfferLi> //SnabborderLista
    {
        public QwickOrderList()
            : base()
        {
            Add(new OfferLi(1, "10000", null, "Kund", "E101", "Artikel E101", "2010-09-25", null, null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Valles mekanik", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(2, "10001", null, "Kund", "", "", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(3, "10002", null, "Kund", "", "", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(4, "10003", null, "Kund", "E106", "Form verktyg", "2010-10-26", null, null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(5, "10004", null, "Kund", "E101", "Artikel E101", "2010-09-25", null, null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(6, "10005", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(7, "10006", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(8, "10007", null, "Kund", "E106", "Form verktyg", "2010-10-26", null, null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(9, "10008", null, "Kund", "E101", "Artikel E101", "2010-09-25", null, null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(10, "10009", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(11, "10010", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(12, "10011", null, "Kund", "E106", "Form verktyg", "2010-10-26", null, null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(13, "10012", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-10-11", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(14, "10013", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(15, "10014", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(16, "10015", null, "Kund", "E106", "Form verktyg", "2010-10-26", null, null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(17, "10016", null, "Kund", "E101", "Artikel E101", "2010-09-25", null, null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(18, "10017", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(19, "10018", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(20, "10019", null, "Kund", "E106", "Form verktyg", "2010-10-26", null, null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(21, "10020", null, "Kund", "E101", "Artikel E101", "2010-09-25", null, null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(22, "10021", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(23, "10022", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(24, "10023", null, "Kund", "E106", "Form verktyg", "2010-10-26", null, null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(25, "10024", null, "Kund", "E101", "Artikel E101", "2010-09-25", null, null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(26, "10025", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(27, "10026", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(28, "10027", null, "Kund", "E106", "Form verktyg", "2010-10-26", null, null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(29, "10028", null, "Kund", "E101", "Artikel E101", "2010-09-25", null, null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(30, "10029", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(31, "10030", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", null, null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(32, "10031", null, "Kund", "E106", "Form verktyg", "2010-10-26", null, null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
        }
    }


    public class DeliveryList : ObservableCollection<OfferLi> //LeveransLista
    {
        public DeliveryList()
            : base()
        {
            Add(new OfferLi(1, "1000", null, "Kund", "E101", "Artikel E101", "2010-10-25", "2010-46-2", null, null, null, null,
                5.00, 5.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(2, "1250", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-46-3", null, null, null, null,
                8, 8, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(3, "1268", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-46-5", null, null, null, null,
                7, 7, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(4, "1269", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-46-5", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(5, "1270", null, "Kund", "E101", "Artikel E101", "2010-10-05", "2010-46-1", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(6, "1272", null, "Kund", "E100", "Hjulaxel LB", "2010-09-05", "2010-46-5", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(7, "1273", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-47-1", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(8, "1274", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-47-5", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(9, "1275", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-48-1", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            
        }
    }

    public class ImportOrderList : ObservableCollection<OfferLi> //ImportLista
    {
        public ImportOrderList()
            : base()
        {
            Add(new OfferLi(1, "10000", null, "Kund", "E101", "Artikel E101", "2010-10-25", "2010-10-11", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(2, "10001", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-11-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(3, "10002", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-11-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(4, "10003", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-11-15", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(5, "10004", null, "Kund", "E101", "Artikel E101", "2010-10-25", "2010-11-11", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(6, "10005", null, "Kund", "E100", "Hjulaxel LB", "2010-10-26", "2010-11-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(7, "10006", null, "Kund", "E104", "Hjulaxel LB", "2010-10-26", "2010-11-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0,
                0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(8, "10007", null, "Kund", "E106", "Form verktyg", "2010-11-06", "2010-11-25", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(9, "10008", null, "Kund", "E101", "Artikel E101", "2010-11-09", "2010-11-22", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(10, "10009", null, "Kund", "E100", "Hjulaxel LB", "2010-11-09", "2010-11-30", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(11, "10010", null, "Kund", "E104", "Hjulaxel LB", "2010-11-09", "2010-11-30", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(12, "10011", null, "Kund", "E106", "Form verktyg", "2010-11-09", "2010-12-15", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
                    "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(13, "10012", null, "Kund", "E101", "Artikel E101", "2010-11-09", "2010-12-11", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
                false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(14, "10013", null, "Kund", "E100", "Hjulaxel LB", "2010-11-10", "2010-12-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
                0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(15, "10014", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
            //    1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
            //    0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(16, "10015", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-11- 15", null, null, null, null,
            //        1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
            //        "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            //Add(new OfferLi(17, "10016", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-10-11", null, null, null, null,
            //    1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
            //    false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            //Add(new OfferLi(18, "10017", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
            //    1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
            //    0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(19, "10018", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
            //    1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
            //    0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(20, "10019", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-11- 15", null, null, null, null,
            //        1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
            //        "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            //Add(new OfferLi(21, "10020", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-10-11", null, null, null, null,
            //    1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
            //    false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            //Add(new OfferLi(22, "10021", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
            //    1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
            //    0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(23, "10022", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
            //    1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
            //    0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(24, "10023", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-11- 15", null, null, null, null,
            //        1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
            //        "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            //Add(new OfferLi(25, "10024", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-10-11", null, null, null, null,
            //    1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
            //    false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            //Add(new OfferLi(26, "10025", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
            //    1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
            //    0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(27, "10026", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
            //    1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
            //    0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(28, "10027", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-11- 15", null, null, null, null,
            //        1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
            //        "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            //Add(new OfferLi(29, "10028", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-10-11", null, null, null, null,
            //    1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false,
            //    false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            //Add(new OfferLi(30, "10029", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
            //    1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
            //    0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(31, "10030", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-08-15", null, null, null, null,
            //    1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0,
            //    0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            //Add(new OfferLi(32, "10031", null, "Kund", "E106", "Form verktyg", "2010-10-26", "2010-11- 15", null, null, null, null,
            //        1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false,
            //        "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
        }
    }


    public class ProductionMtrlList : ObservableCollection<OfferMtrl> //Tillverkningsorder Materialflik 
    {
        public ProductionMtrlList()
            : base()
        {
            Add(new OfferMtrl(1, 1, 1, "K100", "Stål 30mm", "543", "Tibnor", 5, "m", 250, 1250, null, null, "A1", "10", "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(2, 1, 2, "K105", "Bricka ", "543", "Tibnor", 2, "st", 15, 30, null, null, "B12", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(3, 1, 3, "E150", "Hållare", null, null, 2, "st", 1500, 3000, null, null, null, "20", "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(4, 2, 1, "K100", "Stål 50mm", "543", "Tibnor", 5, "m", 350, 1750, null, null, "A1", "10", "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(5, 2, 2, "K105", "Bricka", "543", "Tibnor", 4, "m", 15, 60, null, null, "B12", "10", "2010-07-25", "2010-07-25"));
        }
    }

    public class ProductionMtrlListEmpty : ObservableCollection<OfferMtrl> //Tillverkningsorder Materialflik 
    {
        public ProductionMtrlListEmpty()
            : base()
        {
            
        }
    }



    public class ProductionOPList : ObservableCollection<OfferOP> //Tillverkningsorder Operationsflik
    {
        public ProductionOPList()
            : base()
        {
            Add(new OfferOP(1, 1, 1, "10", "Kapning", 1, 0.25, 0.05, 0.30, 0, 150, 150, 141555, null, null, 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 1, 2, "30", "Svarvning", 2, 0.25, 0.25, 0.50, 0, 500, 500, 141556, null, null, 1, null, 0, 32, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(3, 2, 1, "40", "Fräsning", 3, 0.25, 0.05, 0.30, 0, 150, 150, 141557, null, null, 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(4, 2, 2, "20", "Montering", 5, 0, 1, 1, 0, 250, 250, 141558, null, null, 1, null, 0, 15, "2010-07-25", "2010-07-25"));
        }
    }

    public class ProductionOPListEmpty : ObservableCollection<OfferOP> //Tillverkningsorder Operationsflik
    {
        public ProductionOPListEmpty()
            : base()
        {
           
        }
    }

    public class ProductionListLev : ObservableCollection<OfferLi> //LeveransLista
    {
        public ProductionListLev()
            : base()
        {
            Add(new OfferLi(1, "1000", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-11-16", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false, false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(2, "1001", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-11-16", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(3, "1002", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-11-17", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(4, "1003", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-11- 18", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(5, "1004", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-11-18", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false, false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(6, "1005", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-11-20", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(7, "1006", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-11-20", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(8, "1007", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-11-23", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(9, "1008", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-11-24", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false, false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(10, "1009", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-11-24", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(11, "1010", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-11-25", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(12, "1011", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-11-25", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(13, "1012", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-11-26", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false, false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(14, "1013", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-11-26", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(15, "1014", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-11-26", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(16, "1015", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-12-01", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(17, "1016", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-12-01", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false, false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(18, "1017", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-12-02", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(19, "1018", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-12-03", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(20, "1019", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-12-04", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(21, "1020", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-12-07", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false, false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(22, "1021", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-12-07", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(23, "1022", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-12-07", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(24, "1023", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-12-08", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(25, "1024", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-12-11", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false, false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(26, "1025", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-12-11", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(27, "1026", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-12-15", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(28, "1027", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-12-15", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
            Add(new OfferLi(29, "1028", null, "Kund", "E101", "Artikel E101", "2010-09-25", "2010-12-18", null, null, null, null,
                1.00, 1.00, "158392", null, null, "A1523", "Kalles mekaniska AB", 3582.25, 0.00, 0.00, null, null, false, false, false, false, "Arbete", 0.00, 0.00, 0.00, 5.00, 8.00, 10.00, 0.00, 25.00, "2010-08-01", "2010-07-25"));
            Add(new OfferLi(30, "1029", null, "Kund", "E100", "Hjulaxel LB", "2010-07-26", "2010-12-18", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 5382.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(31, "1030", null, "Kund", "E104", "Hjulaxel LB", "2010-07-26", "2010-12-18", null, null, null, null,
                1, 1, null, null, null, "5865", "Volvo AB", 9895.25, 0, 0, null, null, false, false, false, false, "Order", 0, 0, 0, 5, 8, 10, 0, 25, "2010-08-02", "2010-07-26"));
            Add(new OfferLi(32, "1031", null, "Kund", null, "Form verktyg", "2010-10-26", "2010-12-18", null, null, null, null,
                    1, 1, null, null, null, "7593", "Källs Plastprodukter", 8952.25, 0, 0, null, null, false, false, false, false, "Väntar", 0, 0, 0, 5, 8, 10, 0, 25, "2010-11-02", "2010-10-26"));
        }
    }
    
    
    
    
    
    
    
    public class ArticleList2 : ObservableCollection<OfferMtrl> //Artikel Lista
    {
        public ArticleList2()
            :base()
        {
            Add(new OfferMtrl(1, 1, 1, "K100", "Stål 30mm", "543", "Tibnor", 0, "m", 250, 0, null, null, "15", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(2, 1, 2, "K101", "Stål 35mm ", "543", "Tibnor", 0, "m", 285, 0, null, null, "12", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(3, 1, 2, "K102", "Stål 40mm ", "543", "Tibnor", 0, "m", 300, 0, null, null, "322", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(4, 1, 2, "K103", "Stål 45mm ", "543", "Tibnor", 0, "st", 375, 0, null, null, "5000", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(5, 1, 2, "K104", "Stål 50mm ", "543", "Tibnor", 0, "st", 500, 0, null, null, "158", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(6, 1, 2, "K105", "Bricka ", "543", "Tibnor", 0, "st", 15, 0, null, null, "182", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(7, 1, 2, "K106", "Bricka 25 ", "543", "Tibnor", 0, "st", 15, 0, null, null, "12", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(8, 1, 2, "K107", "Bricka 35", "543", "Tibnor", 0, "st", 15, 0, null, null, "58", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(9, 1, 2, "K108", "Bricka 40", "543", "Tibnor", 0, "st", 15, 0, null, null, "68", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(10, 1, 2, "K109", "Bricka 45", "543", "Tibnor", 0, "st", 15, 0, null, null, "85", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(11, 1, 2, "K110", "Bricka 50", "543", "Tibnor", 0, "st", 15, 0, null, null, "99", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(12, 1, 2, "K111", "Skruv M5", "543", "Tibnor", 0, "st", 15, 0, null, null, "951", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(13, 1, 2, "K112", "Skruv M6 ", "543", "Tibnor", 0, "st", 15, 0, null, null, "156", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(14, 1, 2, "K113", "Skruv M8 ", "543", "Tibnor", 0, "st", 15, 0, null, null, "26", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(15, 1, 2, "K114", "Skruv M10 ", "543", "Tibnor", 0, "st", 15, 0, null, null, "522", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(16, 1, 2, "K115", "Mutter M5 ", "543", "Tibnor", 0, "st", 15, 0, null, null, "153", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(17, 1, 2, "K116", "Mutter M6", "543", "Tibnor", 0, "st", 15, 0, null, null, "1851", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(18, 1, 2, "K117", "Mutter M8 ", "543", "Tibnor", 0, "st", 15, 0, null, null, "1581", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(19, 1, 2, "K118", "Mutter M10 ", "543", "Tibnor", 0, "st", 15, 0, null, null, "1561", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(20, 1, 2, "K119", "Bricka ", "543", "Tibnor", 0, "st", 15, 0, null, null, "15", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(21, 1, 2, "K120", "Bricka ", "543", "Tibnor", 0, "st", 15, 0, null, null, "48", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(22, 1, 2, "K121", "Bricka ", "543", "Tibnor", 0, "st", 15, 0, null, null, "15", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(23, 1, 2, "K122", "Bricka ", "543", "Tibnor", 0, "st", 15, 0, null, null, "11", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(24, 1, 2, "K123", "Bricka ", "543", "Tibnor", 0, "st", 15, 0, null, null, "5215", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(25, 1, 2, "K124", "Bricka ", "543", "Tibnor", 0, "st", 15, 0, null, null, "15", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(26, 1, 2, "K125", "Bricka ", "543", "Tibnor", 0, "st", 15, 0, null, null, "15", null, "2010-07-25", "2010-07-25"));
            Add(new OfferMtrl(27, 1, 3, "E150", "Hållare", null, null, 0, "st", 1500, 0, null, null, null, null, "2010-07-25", "2010-07-25"));
        }
    }

    public class OfferOPList : ObservableCollection<OfferOP> //Förkalkyl Operations flik
    {
        public OfferOPList()
            :base()
        {
            Add(new OfferOP(1, 1, 1, "10", "Kapning", 1, 0.25, 0.05, 0.30, 0, 150, 150, 141555, null, null, 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 1, 2, "30", "Svarvning", 2, 0.25, 0.25, 0.50, 0, 500, 500, 141556, null, null, 1, null, 0, 32, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(3, 2, 1, "40", "Fräsning", 3, 0.25, 0.05, 0.30, 0, 150, 150, 141557, null, null, 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(4, 2, 2, "20", "Montering", 5, 0, 1, 1, 0, 250, 250, 141558, null, null, 1, null, 0, 15, "2010-07-25", "2010-07-25"));
        }
    }

    public class ProductionPlan : ObservableCollection<OfferOP> //Körplan
    {
        public ProductionPlan()
            : base()
        {
            
            Add(new OfferOP(1, 2005, 1, "10", "Kapning", 1, 0.25, 0.05, 0.30, 0, 150, 150, 1345326, "2010-11-10", "2010-11-10", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 2007, 2, "10", "Kapning", 2, 0.25, 0.25, 0.5, 0, 500, 500, 1345330, "2010-11-10", "2010-11-10", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(3, 2006, 1, "10", "Kapning", 3, 0.25, 0.05, 0.30, 0, 150, 150, 1345328, "2010-11-10", "2010-11-10", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(4, 2067, 2, "10", "Kapning", 5, 0.60, 0.50, 0.50, 0, 250, 250, 1345329, "2010-11-10", "2010-11-10", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 2010, 1, "10", "Kapning", 1, 0.25, 0.05, 0.30, 0, 150, 150, 1345327, "2010-11-10", "2010-11-10", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 2017, 2, "10", "Kapning", 2, 0.25, 0.25, 0.5, 0, 500, 500, 1345336, "2010-11-11", "2010-11-11", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(3, 2022, 1, "10", "Kapning", 3, 0.25, 0.05, 0.30, 0, 150, 150, 1345324, "2010-11-11", "2010-11-11", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(4, 2001, 2, "10", "Kapning", 5, 0.50, 0.50, 0.50, 0, 250, 250, 1345329, "2010-11-11", "2010-11-11", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 2010, 1, "10", "Kapning", 1, 0.25, 0.05, 0.30, 0, 150, 150, 1345320, "2010-11-11", "2010-11-11", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 2036, 2, "10", "Kapning", 2, 0.25, 0.25, 0.5, 0, 500, 500, 1345335, "2010-11-11", "2010-11-11", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(3, 2058, 1, "10", "Kapning", 3, 0.25, 0.05, 0.30, 0, 150, 150, 1345339, "2010-11-11", "2010-11-11", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(4, 2098, 2, "10", "Kapning", 5, 0.80, 0.50, 0.50, 0, 250, 250, 1345359, "2010-11-12", "2010-11-12", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 2087, 1, "10", "Kapning", 1, 0.25, 0.05, 0.30, 0, 150, 150, 1345386, "2010-11-12", "2010-11-12", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 2065, 2, "10", "Kapning", 2, 0.25, 0.25, 0.5, 0, 500, 500, 1345390, "2010-11-12", "2010-11-12", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(3, 2044, 1, "10", "Kapning", 3, 0.25, 0.05, 0.30, 0, 150, 150, 1345382, "2010-11-12", "2010-11-12", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(4, 2033, 2, "10", "Kapning", 5, 0.20, 0.50, 0.50, 0, 250, 250, 1345345, "2010-11-13", "2010-11-13", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 2055, 1, "10", "Kapning", 1, 0.25, 0.05, 0.30, 0, 150, 150, 1345376, "2010-11-13", "2010-11-13", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(1, 2088, 2, "10", "Kapning", 2, 0.25, 0.25, 0.5, 0, 500, 500, 1345322, "2010-11-13", "2010-11-13", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(3, 2077, 1, "10", "Kapning", 3, 0.25, 0.05, 0.30, 0, 150, 150, 1345311, "2010-11-13", "2010-11-13", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(4, 2063, 2, "10", "Kapning", 5, 0.32, 0.50, 0.50, 0, 250, 250, 1345334, "2010-11-13", "2010-11-13", 1, null, 0, 15, "2010-07-25", "2010-07-25"));
        
        }
    }

    public class OfferOPListEmpty : ObservableCollection<OfferOP> //Förkalkyl Operations flik
    {
        public OfferOPListEmpty()
            : base()
        {
           
        }
    }

    public class OPList : ObservableCollection<OfferOP> //OperationsLista
    {
        public OPList()
            : base()
        {
            Add(new OfferOP(1, 0, 1, "10", "Kapning", 1, 0, 0, 0, 0, 150, 150, 0, null, null, 0, null, 0, 0, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(2, 0, 2, "20", "Montering", 5, 0, 0, 0, 0, 500, 500, 0, null, null, 0, null, 0, 0, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(3, 0, 3, "30", "Fräsning", 3, 0, 0, 0, 0, 300, 300, 0, null, null, 0, null, 0, 0, "2010-07-25", "2010-07-25"));
            Add(new OfferOP(4, 0, 4, "40", "Svarvning", 2, 0, 0, 0, 0, 250, 150, 0, null, null, 0, null, 0, 0, "2010-07-25", "2010-07-25"));
        }
    } 
    
    
    
    
    
    public class ResourceList1 : ObservableCollection<Resources> //ResursLista
    {
        public ResourceList1()
            :base()
        {
            Add(new Resources(1, "1", "Kap", 250, 6, 1, 0, "2010-08-15"));
            Add(new Resources(2, "2", "Svarv", 450, 5, 1, 0, "2010-08-15"));
            Add(new Resources(3, "3", "Fräs", 450, 5, 1, 0, "2010-08-15"));
            Add(new Resources(4, "4", "Svets", 450, 5, 1, 0, "2010-08-15"));
            Add(new Resources(5, "5", "Laser NC 1", 450, 5, 1, 0, "2010-08-15"));
            Add(new Resources(6, "6", "Bock", 450, 5, 1, 0, "2010-08-15"));
            Add(new Resources(7, "7", "Svarv NC", 450, 5, 1, 0, "2010-08-15"));
            Add(new Resources(8, "8", "Fräs NC", 450, 5, 1, 0, "2010-08-15"));
            Add(new Resources(9, "9", "Kap NC", 450, 5, 1, 0, "2010-08-15"));
            Add(new Resources(10, "10", "Laser NC 2", 450, 5, 1, 0, "2010-08-15"));
           

        }
    }


    public class SupplierList : ObservableCollection<Suppliers> //LeverantörsLista
    {
        public SupplierList()
            :base()
        {
            Add(new Suppliers(853, "543", "Tibnor", "036-555555", "036-777777", "tibnor@jonkoping.se", "www.tibnor.se", "474 55 -5", "5555-5555", null, "SEK", null, 1, 0,"Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            Add(new Suppliers(860, "544", "Edstrands", "036-111111", "036-222222", "edstrands@jonkoping.se", "www.edstrands.se", "474 55 -5", "5555-5555", null, "SEK", null, 1, 0, "Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            Add(new Suppliers(875, "545", "Stålab", "036-222222", "036-333333", "stalab@jonkoping.se", "www.stalab.se", "474 55 -5", "5555-5555", null, "SEK", null, 1, 0, "Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            Add(new Suppliers(4, "546", "Träab", "036-333333", "036-787878", "traab@jonkoping.se", "www.traab.se", "474 55 -5", "5555-5555", null, "SEK", null, 1, 0, "Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            Add(new Suppliers(5, "547", "Plastab", "036-444444", "036-444444", "plastab@jonkoping.se", "www.plastab.se", "474 55 -5", "5555-5555", null, "SEK", null, 1, 0, "Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            Add(new Suppliers(6, "548", "Formab", "036-666666", "036-555555", "formab@jonkoping.se", "www.formab.se", "474 55 -5", "5555-5555", null, "EUR", null, 1, 0, "Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            Add(new Suppliers(7, "549", "Plåtab", "036-777777", "036-666666", "tibnor@jonkoping.se", "www.platab.se", "474 55 -5", "5555-5555", null, "SEK", null, 1, 0, "Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            Add(new Suppliers(8, "550", "Gummab", "036-888888", "036-888888", "tibnor@jonkoping.se", "www.gummab.se", "474 55 -5", "5555-5555", null, "SEK", null, 1, 0, "Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            Add(new Suppliers(9, "551", "Tibnor Linköping", "013-999999", "013-999999", "tibnor@linkoping.se", "www.tibnor-lkpg.se", "474 55 -5", "5555-5555", null, "SEK", null, 1, 0, "Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            Add(new Suppliers(10, "552", "Tibnor Tranås", "0140-121212", "0140-111111", "tibnor@tranas.se", "www.tibnor-tranas.se", "474 55 -5", "5555-5555", null, "SEK", null, 1, 0, "Anders Andersson", "Karl Svensson", "2010-10-09", "2010-10-09"));
            

        }
    }

    public class PurchaseRowList : ObservableCollection<PurchaseRows> //Inköpsrader
    {
        public PurchaseRowList()
            : base()
        { 
        Add(new PurchaseRows(1, 583, "K100", "Köpartikel 100", "SEK", "1", "2000", "st", "Inköpt", "2010-11-15", null, 10, 0, 0 ,45.55, "62", "2010-10-23","2010-10-23"));
        Add(new PurchaseRows(1, 583, "K101", "Köpartikel 101", "SEK", "1", "2000", "st", "Inköpt", "2010-11-15", null, 6, 0, 0, 56.59, "62", "2010-10-23", "2010-10-23"));
        Add(new PurchaseRows(1, 583, "K102", "Köpartikel 102", "SEK", "1", "2000", "st", "Inköpt", "2010-11-15", null, 4, 0, 0, 676.50, "62", "2010-10-23", "2010-10-23"));
        Add(new PurchaseRows(1, 583, "K103", "Köpartikel 103", "SEK", "1", "2000", "st", "Inköpt", "2010-11-15", null, 9, 0, 0, 355.55, "62", "2010-10-23", "2010-10-23"));
        Add(new PurchaseRows(1, 583, "K200", "Köpartikel 200", "SEK", "1", "2006", "st", "Inköpt", "2010-11-15", null, 100, 0, 0, 767.05, "62", "2010-10-23", "2010-10-23"));
        Add(new PurchaseRows(1, 583, "K500", "Köpartikel 500", "SEK", "1", "2010", "st", "Inköpt", "2010-11-15", null, 67, 0, 0, 432.00, "62", "2010-10-23", "2010-10-23"));
        Add(new PurchaseRows(1, 583, "K708", "Köpartikel 708", "SEK", "1", "2078", "st", "Inköpt", "2010-11-15", null, 88, 0, 0, 450.00, "62", "2010-10-23", "2010-10-23"));
        Add(new PurchaseRows(1, 583, "K786", "Köpartikel 786", "SEK", "1", "2003", "st", "Inköpt", "2010-11-15", null, 34, 0, 0, 445.89, "62", "2010-10-23", "2010-10-23"));

        }
    }

    public class PurchaseArticleList : ObservableCollection<PurchaseRows> //Inköps Sidpanel Artiklar
    {
        public PurchaseArticleList()
            : base()
        {
            Add(new PurchaseRows(1, 583, "K100", "Köpartikel 100", "SEK", "1", "2000", "st", "Inköpt", "", null, 1, 0, 0, 45.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K101", "Köpartikel 101", "SEK", "1", "2000", "st", "Inköpt", "", null, 1, 0, 0, 56.59, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K102", "Köpartikel 102", "SEK", "1", "2000", "st", "Inköpt", "", null, 1, 0, 0, 676.50, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K103", "Köpartikel 103", "SEK", "1", "2000", "st", "Inköpt", "", null, 100, 0, 0, 355.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K104", "Köpartikel 104", "SEK", "1", "2006", "st", "Inköpt", "", null, 10, 23,0 , 767.05, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K105", "Köpartikel 105", "SEK", "1", "2010", "st", "Inköpt", "", null, 500, 14 ,0 , 432.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K106", "Köpartikel 106", "SEK", "1", "2078", "st", "Inköpt", "", null, 50, 765, 0, 450.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K107", "Köpartikel 107", "SEK", "1", "2003", "st", "Inköpt", "", null, 25, 424 , 0, 445.89, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K108", "Köpartikel 108", "SEK", "1", "2000", "st", "Inköpt", "", null, 10, 43 ,0 , 45.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K109", "Köpartikel 109", "SEK", "1", "2000", "st", "Inköpt", "", null, 20,66 ,0 , 56.59, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K110", "Köpartikel 110", "SEK", "1", "2000", "st", "Inköpt", "", null, 1, 36, 0, 676.50, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K111", "Köpartikel 111", "SEK", "1", "2000", "st", "Inköpt", "", null, 50, 356,0 , 355.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K112", "Köpartikel 112", "SEK", "1", "2006", "st", "Inköpt", "", null, 200,653 ,0 , 767.05, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K113", "Köpartikel 113", "SEK", "1", "2010", "st", "Inköpt", "", null, 20,33 ,0 , 432.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K114", "Köpartikel 114", "SEK", "1", "2078", "st", "Inköpt", "", null, 10, 88,0 , 450.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K115", "Köpartikel 115", "SEK", "1", "2003", "st", "Inköpt", "", null, 10, 69,0 , 445.89, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K108", "Köpartikel 108", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,908 ,0 , 45.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K109", "Köpartikel 109", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,55 ,0 , 56.59, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K110", "Köpartikel 110", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,24 ,0 , 676.50, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K111", "Köpartikel 111", "SEK", "1", "2000", "st", "Inköpt", "", null, 10, 96,0 , 355.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K112", "Köpartikel 112", "SEK", "1", "2006", "st", "Inköpt", "", null, 10,42 ,0 , 767.05, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K113", "Köpartikel 113", "SEK", "1", "2010", "st", "Inköpt", "", null, 10,22 ,0 , 432.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K114", "Köpartikel 114", "SEK", "1", "2078", "st", "Inköpt", "", null, 10,895 ,0 , 450.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K115", "Köpartikel 115", "SEK", "1", "2003", "st", "Inköpt", "", null, 10, 22,0 , 445.89, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K200", "Köpartikel 200", "SEK", "1", "2000", "st", "Inköpt", "", null, 10, 0, 0, 45.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K205", "Köpartikel 205", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,42 ,0, 56.59, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K206", "Köpartikel 206", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,426 ,0 , 676.50, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K207", "Köpartikel 207", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,4222 ,0 , 355.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K208", "Köpartikel 208", "SEK", "1", "2006", "st", "Inköpt", "", null, 10,6775 ,0 , 767.05, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K209", "Köpartikel 209", "SEK", "1", "2010", "st", "Inköpt", "", null, 10,773 , 0, 432.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K210", "Köpartikel 210", "SEK", "1", "2078", "st", "Inköpt", "", null, 10,46 ,0 , 450.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K211", "Köpartikel 211", "SEK", "1", "2003", "st", "Inköpt", "", null, 10,4 ,0 , 445.89, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K212", "Köpartikel 212", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,688 ,0 , 45.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K213", "Köpartikel 213", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,789 ,0 , 56.59, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K300", "Köpartikel 300", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,66 ,0 , 676.50, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K301", "Köpartikel 301", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,97 ,0 , 355.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K302", "Köpartikel 302", "SEK", "1", "2006", "st", "Inköpt", "", null, 10,967 ,0 , 767.05, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K303", "Köpartikel 303", "SEK", "1", "2010", "st", "Inköpt", "", null, 10, 99,0 , 432.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K304", "Köpartikel 304", "SEK", "1", "2078", "st", "Inköpt", "", null, 10,55 ,0, 450.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K305", "Köpartikel 305", "SEK", "1", "2003", "st", "Inköpt", "", null, 10,789 ,0 , 445.89, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K306", "Köpartikel 306", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,97 ,0 , 45.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K307", "Köpartikel 307", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,697 ,0 , 56.59, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K308", "Köpartikel 308", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,976 ,0 , 676.50, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K309", "Köpartikel 309", "SEK", "1", "2000", "st", "Inköpt", "", null, 10,97 ,0 , 355.55, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K310", "Köpartikel 310", "SEK", "1", "2006", "st", "Inköpt", "", null, 10,977 ,0 , 767.05, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K311", "Köpartikel 311", "SEK", "1", "2010", "st", "Inköpt", "", null, 10,65 ,0 , 432.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K312", "Köpartikel 312", "SEK", "1", "2078", "st", "Inköpt", "", null, 10,990 ,0 , 450.00, "62", "2010-10-23", "2010-10-23"));
            Add(new PurchaseRows(1, 583, "K313", "Köpartikel 313", "SEK", "1", "2003", "st", "Inköpt", "", null, 10,54 ,0 , 445.89, "62", "2010-10-23", "2010-10-23"));
        }
    }


    public class PurchaseRowListEmpty : ObservableCollection<PurchaseRows> //Inköpsrader tom
    {
        public PurchaseRowListEmpty()
            : base()
        {
            

        }
    }


    public class EarlierDeliveryList : ObservableCollection<EarlierDelivery> //Leverans tidigare leveranser
    { 
      public EarlierDeliveryList()
          :base()
      {
        Add(new EarlierDelivery(1,"2010-09-16","1000-1","3","1","2"));
        Add(new EarlierDelivery(1,"2010-10-22","1000-2","1","0","1"));



    
      }
    }

    public class OrderStructureList : ObservableCollection<OrderStructure> //Leverans struktur
    {
        public OrderStructureList()
            : base()
        {
            Add(new OrderStructure(1, "4001", "E105", "Egenartikel 105", "6", "6", "0", "Ja", "Arbete"));
            Add(new OrderStructure(1, "4002", "E107", "Egenartikel 107", "10", "10", "0", "Ja", "Arbete"));
            Add(new OrderStructure(1, "4003", "E200", "Egenartikel 200", "1", "1", "0", "Ja", "Arbete"));
            Add(new OrderStructure(1, "4004", "E400", "Egenartikel 400", "50", "50", "0", "Ja", "Arbete"));
        }
    }
    public class DocumentFK : ObservableCollection<Document>
    {
        public DocumentFK()
            : base()
        {
            Add(new Document("ID1355", "Ritning", "\\Anet\\Dokument\\I1355.dwg"));
            Add(new Document("ID1385", "Kontrollinstruktion", "\\Anet\\Dokument\\Kontroll.docx"));
        }
    }

    public class DocumentTO : ObservableCollection<Document>
    {
        public DocumentTO()
            : base()
        {
            Add(new Document("ID1398", "Ritning", "\\Anet\\Dokument\\I1398.dwg"));
            Add(new Document("ID115", "Kontrollinstruktion", "\\Anet\\Dokument\\Kontroll.docx"));
        }
    }

    public class DocumentP : ObservableCollection<Document>
    {
        public DocumentP()
            : base()
        {
            Add(new Document("ID1400", "Ritning", "\\Anet\\Dokument\\I1400.dwg"));

        }
    }

    public class DocumentMA : ObservableCollection<Document>
    {
        public DocumentMA()
            : base()
        {
            Add(new Document("ID198", "Ínstruktion för Avsyningskontroll", "\\Anet\\Dokument\\Kontroll.docx"));
        }
    }


    public class ToDos
    {
        private bool IsTrue;
        private bool IsTrue2;
        private bool IsTrue3;
        private string Order;
        private string ArticleNo;
        private string Description;
        private string Module;
        private string DeliveryDate;
        private string EmployeeNo;
        private string Resource;
        private string Comment;


        public ToDos(bool IsT, bool IsT2, bool IsT3, string ONo, string ArtNo, string Desc, string Mod, string DDate, string EmplNo, string Res, string comment )
        {
            this.IsTrue = IsT;
            this.IsTrue2 = IsT2;
            this.IsTrue3 = IsT3;
            this.Order = ONo;
            this.Description = Desc;
            this.ArticleNo = ArtNo;
            this.Module = Mod;
            this.DeliveryDate = DDate;
            this.EmployeeNo = EmplNo;
            this.Resource = Res;
            this.Comment = comment;
        }

        public bool ist
        {
            get { return IsTrue; }
            set { IsTrue = value; }
        }

        public bool ist2
        {
            get { return IsTrue2; }
            set { IsTrue2 = value; }
        }

        public bool ist3
        {
            get { return IsTrue3; }
            set { IsTrue3 = value; }
        }

        public string order
        {
            get { return Order; }
            set { Order = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string articleNo
        {
            get { return ArticleNo; }
            set { ArticleNo = value; }
        }

        public string module
        {
            get { return Module; }
            set { Module = value; }
        }

        public string deliverydate
        {
            get { return DeliveryDate; }
            set { DeliveryDate = value; }
        }

        public string employeeno
        {
            get { return EmployeeNo; }
            set { EmployeeNo = value; }
        }

        public string resource
        {
            get { return Resource; }
            set { Resource = value; }
        }
        
        public string comment
        {
            get { return Comment; }
            set { Comment = value; }
        }
    }


    public class OfferLi
    {
        public long OfferOrderId;
        public string OfferOrderNo;
        public string MainOrder;
        public string OrderType;
        public string ArticleNo;
        public string Description;
        public string OrderDate;
        public string DeliveryDate;
        public string DeliveryDateWeek;
        public string ActualDeliveryDate;
        public string ReadyDate;
        public string InvoiceDate;
        public double Quantity;
        public double CustomerQuantity;
        public string Drawing;
        public string DrawingRevision;
        public string PartOf;
        public string CustomerNo;
        public string CustomerName;
        public double CalculatedCost;
        public double ArticleCost;
        public double InvoicedCost;
        public string InvoiceNo;
        public string BuisnessOrderNo;
        public bool BuisnessOrder;
        public bool BuisnessOffer;
        public bool BuisnessInvoice;
        public bool InvoiceCreated;
        public string Status;
        public double AddOnManufacture;
        public double AddOnMaterial;
        public double AddOnSails;
        public double AddOnManufactureP;
        public double AddOnMaterialP;
        public double AddOnSailsP;
        public double AddOnBuisness;
        public double AddOnBuisnessP;
        public string Changed;
        public string CreationDate;


        public OfferLi(long offerOrderId, string offerOrderNo, string mainOrder, string orderType, string ArticleNo, string Description,
            string OrderDate, string DeliveryDate, string DeliveryDateWeek, string ActualDeliveryDate, string ReadyDate, string InvoiceDate,
            double Quantity, double CustomerQuantity, string Drawing, string DrawingRevision, string PartOf, string CustomerNo, string CustomerName, double CalculatedCost,
            double ArticleCost,double InvoicedCost, string InvoiceNo, string BuisnessOrderNo, bool BuisnessOrder, bool BuisnessOffer, bool BuisnessInvoice,
            bool InvoiceCreated, string Status, double AddOnManufacture, double AddOnMaterial, double AddOnSails, double AddOnManufactureP, double AddOnMaterialP,
            double AddOnSailsP, double AddOnBuisness, double AddOnBuisnessP, string Changed, string CreationDate)
        {
            this.OfferOrderId = offerOrderId;
            this.OfferOrderNo = offerOrderNo;
            this.MainOrder= mainOrder;
            this.OrderType=orderType;
            this.ArticleNo = ArticleNo;
            this.Description = Description;
            this.OrderDate = OrderDate;
            this.DeliveryDate = DeliveryDate;
            this.DeliveryDateWeek = DeliveryDateWeek;
            this.ActualDeliveryDate = ActualDeliveryDate;
            this.ReadyDate = ReadyDate;
            this.InvoiceDate = InvoiceDate;
            this.Quantity = Quantity;
            this.CustomerQuantity = CustomerQuantity;
            this.Drawing = Drawing;
            this.DrawingRevision = DrawingRevision;
            this.PartOf = PartOf;
            this.CustomerNo = CustomerNo;
            this.CustomerName = CustomerName;
            this.CalculatedCost = CalculatedCost;
            this.ArticleCost = ArticleCost;
            this.InvoicedCost = InvoicedCost;
            this.InvoiceNo = InvoiceNo;
            this.BuisnessOrderNo = BuisnessOrderNo;
            this.BuisnessOrder = BuisnessOrder;
            this.BuisnessOffer = BuisnessOffer;
            this.BuisnessInvoice = BuisnessInvoice;
            this.InvoiceCreated = InvoiceCreated;
            this.Status = Status;
            this.AddOnManufacture = AddOnManufacture;
            this.AddOnMaterial = AddOnMaterial;
            this.AddOnSails = AddOnSails;
            this.AddOnManufactureP = AddOnManufactureP;
            this.AddOnMaterialP = AddOnMaterialP;
            this.AddOnSailsP = AddOnSailsP;
            this.AddOnBuisness = AddOnBuisness;
            this.AddOnBuisnessP = AddOnBuisnessP;
            this.Changed = Changed;
            this.CreationDate = CreationDate;
            
        }

        public long offerorderid
        {
            get { return OfferOrderId; }
            set { OfferOrderId = value; }
        }


        public string offerorderno
        {
            get { return OfferOrderNo; }
            set { OfferOrderNo=value;}
        }

        public string mainorder
        {
            get { return MainOrder; }
            set { MainOrder = value; }
        }

        public string ordertype
        {
            get { return OrderType; }
            set { OrderType = value; }
        }

        public string articleno
        {
            get { return ArticleNo; }
            set { ArticleNo = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string orderdate
        {
            get { return OrderDate; }
            set { OrderDate = value; }
        }

        public string deliverydate
        {
            get { return DeliveryDate; }
            set { DeliveryDate = value; }
        }

        public string deliverydateweek
        {
            get { return DeliveryDateWeek; }
            set { DeliveryDateWeek = value; }
        }

        public string actualdeliverydate
        {
            get { return ActualDeliveryDate; }
            set { ActualDeliveryDate = value; }
        }

        public string readydate
        {
            get { return ReadyDate; }
            set { ReadyDate = value; }
        }

        public string invoicedate
        {
            get { return InvoiceDate; }
            set { InvoiceDate = value; }
        }

        public double quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public double customerquantity
        {
            get { return CustomerQuantity; }
            set { CustomerQuantity = value; }
        }
        
        public string drawing
        {
            get { return Drawing; }
            set { Drawing = value; }
        }

        public string drawingrevision
        {
            get { return DrawingRevision; }
            set { DrawingRevision = value; }
        }

        public string partof
        {
            get { return PartOf;}
            set { PartOf = value; }
        }

        public string customerno
        {
            get { return CustomerNo; }
            set { CustomerNo = value; }
        }

        public string customername
        {
            get { return CustomerName; }
            set { CustomerName = value; }
        }

        public double calculatedcost
        {
            get { return CalculatedCost; }
            set { CalculatedCost = value; }
        }

        public double articlecost
        {
            get { return ArticleCost; }
            set { ArticleCost = value; }
        }

        public double invoicedcost
        {
            get { return InvoicedCost;}
            set {InvoicedCost=value;}
        }

        public string invoiceno
        {
            get { return InvoiceNo; }
            set { InvoiceNo = value; }
        }

        public string buisnessorderno
        {
            get { return BuisnessOrderNo; }
            set { BuisnessOrderNo = value; }
        }

        public bool buisnessorder
        {
            get { return BuisnessOrder; }
            set { BuisnessOrder = value; }
        }

        public bool buisnessoffer
        {
            get { return BuisnessOffer; }
            set { BuisnessOffer = value; }
        }

        public bool buisnessinvoice
        {
            get { return BuisnessInvoice; }
            set { BuisnessInvoice = value; }
        }

        public bool invoicecreated
        {
            get { return InvoiceCreated; }
            set { InvoiceCreated = value; }
        }

        public string status
        {
            get { return Status; }
            set { Status = value; }
        }

        public double addonmanufacture
        {
            get { return AddOnManufacture; }
            set { AddOnManufacture = value; }
        }

        public double addonmaterial
        {
            get { return AddOnMaterial; }
            set { AddOnMaterial = value; }
        }
        public double addonsails
        {
            get { return AddOnSails; }
            set { AddOnSails = value; }
        }

        public double addonmanufacturep
        {
            get { return AddOnManufactureP; }
            set { AddOnManufactureP = value; }
        }

        public double addommaterialp
        {
            get { return AddOnMaterialP; }
            set { AddOnMaterialP = value; }
        }

        public double addonsailsp
        {
            get { return AddOnSailsP; }
            set { AddOnSailsP = value; }
        }

        public double addonbuisness
        {
            get { return AddOnBuisness; }
            set { AddOnBuisness = value; }
        }

        public double addonbuisnessp
        {
            get { return AddOnBuisnessP; }
            set { AddOnBuisnessP = value; }
        }

        public string changed
        {
            get { return Changed; }
            set { Changed = value; }
        }


        public string creationdate
        {
            get { return CreationDate; }
            set { CreationDate = value; }
        }
    }

    public class OfferMtrl
    {
        public long OfferMaterialId;
        public long OfferOrderId;
        public long Position;
        public string ArticleNo;
        public string Description;
        public string SupplierNo;
        public string SupplierName;
        public double Quantity;
        public string UnitCode;
        public double PiecePrice;
        public double TotalCost;
        public string PurchasingDate;
        public string Homedate;
        public string Location;
        public string OperationNo;
        public string Changed;
        public string CreationDate;


        public OfferMtrl()
        {

        }


        public OfferMtrl(long offerMaterialId, long offerOrderId, long position, string articleNo,
             string description, string supplierNo, string supplierName, double quantity, string unitCode,
            double piecePrice, double totalCost, string purchasingDate, string homedate, string location,
            string operationNo, string changed, string creationDate)
        {
            this.OfferMaterialId = offerMaterialId;
            this.OfferOrderId = offerOrderId;
            this.Position = position;
            this.ArticleNo = articleNo;
            this.Description = description;
            this.SupplierNo = supplierNo;
            this.SupplierName = supplierName;
            this.Quantity = quantity;
            this.UnitCode = unitCode;
            this.PiecePrice = piecePrice;
            this.TotalCost = totalCost;
            this.PurchasingDate = purchasingDate;
            this.Homedate = homedate;
            this.Location = location;
            this.OperationNo = operationNo;
            this.Changed = changed;
            this.CreationDate = creationDate;
        }

        public long offerMaterialId
        {
            get { return OfferMaterialId; }
            set { OfferMaterialId = value; }
        }

        public long offerOrderId
        {
            get { return OfferOrderId; }
            set { OfferOrderId = value; }
        }

        public long position
        {
            get { return Position; }
            set { Position = value; }
        }

        public string articleNo
        {
            get { return ArticleNo; }
            set { ArticleNo = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string supplierNo
        {
            get { return SupplierNo; }
            set { SupplierNo = value; }
        }

        public string supplierName
        {
            get { return SupplierName; }
            set { SupplierName = value; }
        }

        public double quantity 
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public string unitCode
        {
            get { return UnitCode; }
            set { UnitCode = value; }
        }

        public double piecePrice
        {
            get { return PiecePrice; }
            set { PiecePrice = value; }
        }

        public string purchasingDate
        {
            get { return PurchasingDate; }
            set { PurchasingDate = value; }
        }

        public double totalCost
        {
            get { return TotalCost; }
            set { TotalCost = value; }
        }

        public string homedate
        {
            get { return Homedate; }
            set { Homedate = value; }
        }
        public string location
        {
            get { return Location; }
            set { Location = value; }
        }
        public string operationNo
        {
            get { return OperationNo; }
            set { OperationNo = value; }
        }
        public string changed
        {
            get { return Changed; }
            set { Changed = value; }
        }
        public string creationDate
        {
            get { return CreationDate; }
            set { CreationDate = value; }
        }
        

    }
    public class OfferOP
    {
        public long OfferOperationId;
        public long OfferOrderId;
        public long Position;
        public string OperationNo;
        public string Description;
        public Int32 ResourceNo;
        public double SetupTime;
        public double PieceTime;
        public double TotalTime;
        public double TimeWorked;
        public double OperationCost;
        public double PiecePrice;
        public long OperationCode;
        public string StartDate;
        public string StopDate;
        public int Status;
        public string Location;
        public int Priority;
        public int StaffNo;
        public string Changed;
        public string CreationDate;


        public OfferOP(long offerOperationId, long offerOrderId, long position, string operationNo, string description, Int32 resourceNo, double setupTime,
            double pieceTime, double totalTime, double timeWorked, double operationCost, double piecePrice, long operationCode, string startDate,
            string stopDate, int status, string location, int priority, int staffNo, string changed, string creationDate)
        {
            this.OfferOperationId = offerOperationId;
            this.OfferOrderId = offerOrderId;
            this.Position = position;
            this.OperationNo = operationNo;
            this.Description = description;
            this.ResourceNo = resourceNo;
            this.SetupTime = setupTime;
            this.PieceTime = pieceTime;
            this.TotalTime = totalTime;
            this.TimeWorked = timeWorked;
            this.OperationCost = operationCost;
            this.PiecePrice = piecePrice;
            this.OperationCode = operationCode;
            this.StartDate = startDate;
            this.StopDate = stopDate;
            this.Status = status;
            this.Location = location;
            this.Priority = priority;
            this.StaffNo = staffNo;
            this.Changed = changed;
            this.CreationDate = creationDate;
        }

        public long offerOperationId
        {
            get { return OfferOperationId; }
            set { OfferOperationId = value; }
        }

        public long offerOrderId
        {
            get { return OfferOrderId; }
            set { OfferOrderId = value; }
        }
        
        public long position
        {
            get { return Position; }
            set { Position = value; }
        }

        public string operationNo
        {
            get { return OperationNo; }
            set { OperationNo = value; }
        }

        public Int32 resourceNo
        {
            get { return ResourceNo; }
            set { ResourceNo = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public double setupTime
        {
            get { return SetupTime; }
            set { SetupTime = value; }
        }

        public double pieceTime
        {
            get { return PieceTime; }
            set { PieceTime = value; }
        }

        public double totalTime
        {
            get { return TotalTime; }
            set { TotalTime = value; }
        }

        public double timeWorked
        {
            get { return TimeWorked; }
            set { TimeWorked = value; }
        }

        public double operationCost
        {
            get { return OperationCost; }
            set { OperationCost = value; }
        }
        public double piecePrice
        {
            get { return PiecePrice; }
            set { PiecePrice = value; }
        }

        public long operationCode
        {
            get { return OperationCode; }
            set { OperationCode = value; }
        }

        public string startDate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }

        public string stopDate
        {
            get { return StopDate; }
            set { StopDate = value; }
        }
        public string location
        {
            get { return Location; }
            set { Location = value; }
        }

        public int status
        {
            get { return Status; }
            set { Status = value; }
        }

        public int priority
        {
            get { return Priority; }
            set { Priority = value; }
        }
        
        public int staffNo
        {
            get { return StaffNo; }
            set { StaffNo = value; }
        }

        public string changed
        {
            get { return Changed; }
            set { Changed = value; }
        }

        public string creationDate
        {
            get { return CreationDate; }
            set { CreationDate = value; }
        }
    }


    public class Resources
    {
        public long ResourceId;
        public string ResourceNo;
        public string Description;
        public double Cost;
        public double DayCap;
        public int Department;
        public int InActive;
        public string CreationDate;

        public Resources(long resourceId, string resourceNo, string description, double cost, double dayCap, Int32 department, Int32 inActive,
             string creationDate)
        {
            this.ResourceId = resourceId;
            this.ResourceNo = resourceNo;
            this.Description = description;
            this.Cost = cost;
            this.DayCap = dayCap;
            this.Department = department;
            this.InActive = inActive;
            this.CreationDate = creationDate;
        }

        public long resourceId
        {
            get { return ResourceId; }
            set { ResourceId = value; }
        }

        public string resourceNo
        {
            get { return ResourceNo; }
            set { ResourceNo = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public double cost
        {
            get { return Cost; }
            set { Cost = value; }
        }

        public double dayCap
        {
            get { return DayCap; }
            set { DayCap = value; }
        }

        public Int32 department
        {
            get { return Department; }
            set { Department = value; }
        }

        public Int32 inActive
        {
            get { return InActive; }
            set { InActive = value; }
        }

        public string creationDate
        {
            get { return CreationDate; }
            set { CreationDate = value; }
        }
    }
    public class Suppliers
    {

        public long SupplierId;
        public string SupplierNo;
        public string SupplierName;
        public string Phone;
        public string Fax;
        public string Email;
        public string HomePage;
        public string PlusGiro;
        public string BankGiro;
        public string VATRegNo;
        public string Currency;
        public string SortName;
        public int PriceListNo;
        public Int16 InActive;
        public string OurReference;
        public string YourReference;
        public string DeliveryDate;
        public string Changed;
        public string CreationDate;
        
        public Suppliers(long supplierId, string supplierNo, string supplierName, string phone, string fax, string email, string homePage, string plusGiro,
            string bankGiro, string vATRegNo, string currency, string sortName, int priceListNo, Int16 inActive, string ourReference, string yourReference ,
            string changed, string creationDate)
            :base()
        {
            this.SupplierId = supplierId;
            this.SupplierNo = supplierNo;
            this.SupplierName=supplierName;
            this.Phone = phone;
            this.Fax = fax;
            this.Email = email;
            this.HomePage = homePage;
            this.PlusGiro = plusGiro;
            this.BankGiro = bankGiro;
            this.VATRegNo = vATRegNo;
            this.Currency = currency;
            this.SortName = sortName;
            this.PriceListNo = priceListNo;
            this.InActive = inActive;
            this.OurReference = ourReference;
            this.YourReference = yourReference;
            //this.DeliveryDate = deliveryDate;
            this.Changed = changed;
            this.CreationDate = creationDate;

        }

        public long supplierId
        {
            get { return SupplierId; }
            set { SupplierId = value; }
        }

        public string supplierNo
        {
            get { return SupplierNo; }
            set { SupplierNo = value; }
        }

        public string supplierName
        {
            get { return SupplierName; }
            set { SupplierName = value; }
        }

        public string phone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string fax
        {
            get { return Fax; }
            set { Fax = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string homePage
        {
            get { return HomePage; }
            set { HomePage = value; }
        }

        public string bankGiro
        {
            get { return BankGiro; }
            set { BankGiro = value; }
        }

        public string plusGiro
        {
            get { return PlusGiro; }
            set { PlusGiro = value; }
        }

        public string vATRegNo
        {
            get { return VATRegNo; }
            set { VATRegNo = value; }
        }

        public string currency
        {
            get { return Currency; }
            set { Currency = value; }
        }

        public string sortName
        {
            get { return SortName; }
            set { SortName = value; }
        }

        public int priceListNo
        {
            get { return PriceListNo; }
            set { PriceListNo = value; }
        }

        public Int16 inActive
        {
            get { return InActive; }
            set { InActive = value; }
        }

        public string ourReference
        {
            get { return OurReference; }
            set { OurReference = value; }
        }

        public string yourReference
        {
            get { return YourReference; }
            set { YourReference = value; }
        }
        
        public string deliveryDate
        {
            get { return DeliveryDate; }
            set { DeliveryDate = value; }
        }
        
        
        public string changed
        {
            get { return Changed; }
            set { Changed = value; }
        }

        public string creationDate
        {
            get { return CreationDate; }
            set { CreationDate = value; }
        }
    }

    public class PurchaseRows
    {
        public long PurchaseRowId;
        public long PurchaseNo;
        public string ArticleNo;
        public string Description;
        public string CurrencyCode;
        public string CurrencyNo;
        public string ProductionOrderNo;
        public string Unit;
        public string Status;
        public string DeliveryDate;
        public string ActualDeliveryDate;
        public double Quantity;
        public double RestQuantity;
        public double DeliveredQuantity;
        public double Price;
        public string UserNo;
        public string Changed;
        public string CreationDate;

        public PurchaseRows(long purchaseRowId, long purchaseNo, string articleNo, string description, string currencyCode, string currencyNo,
            string productionOrderNo, string unit, string status, string deliveryDate, string actualDeliveryDate, double quantity,
            double restQuantity, double deliveredQuantity, double price, string userNo, string changed, string creationDate)
            :base()
        {
            this.PurchaseRowId = purchaseRowId;
            this.PurchaseNo = purchaseNo;
            this.ArticleNo = articleNo;
            this.Description = description;
            this.CurrencyCode = currencyCode;
            this.CurrencyNo = currencyNo;
            this.ProductionOrderNo = productionOrderNo;
            this.Unit = unit;
            this.Status = status;
            this.DeliveryDate = deliveryDate;
            this.ActualDeliveryDate = actualDeliveryDate;
            this.Quantity = quantity;
            this.RestQuantity = restQuantity;
            this.DeliveredQuantity = deliveredQuantity;
            this.Price = price;
            this.UserNo = userNo;
            this.Changed = changed;
            this.CreationDate = creationDate;

        }

        public long purchaseRowId
        {
            get { return PurchaseRowId; }
            set { PurchaseRowId = value; }
        }

        public long purchaseNo
        {
            get { return PurchaseNo; }
            set { PurchaseNo = value; }
        }

        public string articleNo
        {
            get { return ArticleNo; }
            set { ArticleNo = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string currencyCode
        {
            get { return CurrencyCode; }
            set { CurrencyCode = value; }
        }

        public string currencyNo
        {
            get { return CurrencyNo; }
            set { CurrencyNo = value; }
        }

        public string productionOrderNo
        {
            get { return ProductionOrderNo; }
            set { ProductionOrderNo=value; }
        }

        public string unit
        {
            get { return Unit; }
            set { Unit = value; }
        }

        public string status
        {
            get { return Status; }
            set { Status = value; }
        }

        public string deliveryDate
        {
            get { return DeliveryDate; }
            set { DeliveryDate = value; }
        }

        public string actualDeliveryDate
        {
            get { return ActualDeliveryDate; }
            set { ActualDeliveryDate = value; }
        }

        public double quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public double restQuantity
        {
            get { return RestQuantity; }
            set { RestQuantity = value; }
        }
        public double deliveredQuantity
        {
            get { return DeliveredQuantity; }
            set { DeliveredQuantity = value; }
        }
        public double price
        {
            get { return Price; }
            set { Price = value; }
        }
        public string userNo
        {
            get { return UserNo; }
            set { UserNo = value; }
        }

        public string changed
        {
            get { return Changed; }
            set { Changed = value; }
        }

        public string creationDate
        {
            get { return CreationDate; }
            set { CreationDate = value; }
        }

    }
    public class OrderStructure
    {
        public long OrderId;
        public string ProductionOrderNo;
        public string ArticleNo;
        public string Description;
        public string Quantity;
        public string DeliverQuantity;
        public string StorageQuantity;
        public string MarkOff;
        public string Status;


        public OrderStructure(long orderId, string productionOrderNo, string articleNo, string description, string quantity,
            string deliverQuantity, string storageQuantity, string markOff, string status)
            : base()
        {
            this.OrderId = orderId;
            this.ProductionOrderNo = productionOrderNo;
            this.ArticleNo = articleNo;
            this.Description = description;
            this.Quantity = quantity;
            this.DeliverQuantity = deliverQuantity;
            this.StorageQuantity = storageQuantity;
            this.MarkOff = markOff;
            this.Status = status;
        }

        public long orderId
        {
            get { return OrderId; }
            set { OrderId = value; }
        }

        public string productionOrderNo
        {
            get { return ProductionOrderNo; }
            set { ProductionOrderNo = value; }
        }
        public string articleNo
        {
            get { return ArticleNo;}
            set { ArticleNo = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public string deliverQuantity
        {
            get { return DeliverQuantity; }
            set { DeliverQuantity = value; }
        }

        public string storageQuantity
        {
            get { return StorageQuantity; }
            set { StorageQuantity = value; }
        }

        public string markOff
        {
            get { return MarkOff; }
            set { MarkOff = value; }
        }

        public string status
        {
            get { return Status; }
            set { Status = value; }
        }
    }

    public class EarlierDelivery
    {
        public long OrderId;
        public string DeliveryDate;
        public string DeliveryNo;
        public string LeftToDeliver;
        public string DeliveredQuantity;
        public string StorageQuantity;


        public EarlierDelivery(long orderId, string deliveryDate, string deliveryNo, string leftToDeliver, string deliveredQuantity,
            string storageQuantity)
            : base()
        {
            this.OrderId = orderId;
            this.DeliveryDate = deliveryDate;
            this.DeliveryNo = deliveryNo;
            this.LeftToDeliver = leftToDeliver;
            this.DeliveredQuantity = deliveredQuantity;
            this.StorageQuantity = storageQuantity;
        }   

        public long orderId
        {
            get { return OrderId; }
            set { OrderId = value; }
        }

        public string deliveryDate
        {
            get { return DeliveryDate; }
            set { DeliveryDate = value; }
        }
        public string deliveryNo
        {
            get { return DeliveryNo; }
            set { DeliveryNo = value; }
        }

        public string leftToDeliver
        {
            get { return LeftToDeliver; }
            set { LeftToDeliver = value; }
        }

        public string deliveredQuantity
        {
            get { return DeliveredQuantity; }
            set { DeliveredQuantity = value; }
        }

        public string storageQuantity
        {
            get { return StorageQuantity; }
            set { StorageQuantity = value; }
        }
          

        

    
    }


    public class Document
    {
        public string DocumentId;
        public string Description;
        public string Path;

        public Document(string documentId, string description, string path)
            : base()
        {
            this.DocumentId = documentId;
            this.Description = description;
            this.Path = path;
        }

        public string documentId
        {
            get { return DocumentId; }
            set { DocumentId = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string path
        {
            get { return Path; }
            set { Path = value; }
        }
    }


}



