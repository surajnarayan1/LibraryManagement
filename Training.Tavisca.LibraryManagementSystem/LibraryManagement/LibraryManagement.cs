using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.Tavisca.LibraryManagementSystem;

namespace LibraryManagement
{
    [TestClass]
    public class LibraryCheck
    {
        [TestMethod]
        public void Check_Wheather_The_Book_Is_Present()

        {
            LibraryManager libraryManager = new LibraryManager();
            Book shortStories = new Book();
            shortStories.Author = "Rudyard keepling";
            //To note down Status of book and note  it before Issuing them ;
            shortStories.Status = BookCondition.New;
           
            shortStories.Generes = Category.fiction;
            shortStories.Name = "The wonderLand";
            shortStories.PublishYear = "2016";
            libraryManager.IssueBook(shortStories);

            Assert.AreSame(shortStories.Name, libraryManager.CheckBookIsPresent("The wonderLand").Name);






        }
        [TestMethod]
        public void Check_The_Number_of_book_Issued()
        {
            LibraryManager libraryManager = new LibraryManager();
            Book shortpoem = new Book();
            shortpoem.Author = "Robert Bills";
            shortpoem.Generes = Category.Romantic;
            shortpoem.Name = "Wavin";
            shortpoem.PublishYear = "2017";
            shortpoem.Status = BookCondition.Old;
            libraryManager.IssueBook(shortpoem);


            Assert.AreEqual(1, libraryManager.NumberOfBookIssued());


        }
        [TestMethod]
       
        public  void To_Check_Wheather_The_BooK_Is_Removed_From_List()
        {


            LibraryManager libraryManager = new LibraryManager();
            Book shortpoem = new Book();
            shortpoem.Author = "Robert Bills";
            shortpoem.Generes = Category.Romantic;
            shortpoem.Name = "Wavin";
            shortpoem.PublishYear = "2017";
            shortpoem.Status = BookCondition.Old;
            libraryManager.IssueBook(shortpoem);
          




        }


       






    }
}
