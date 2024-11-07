using DataAccess.Model;

namespace BergVinGUI
{
        public partial class MainPage : ContentPage
        {

            private List<LagerDTO> selectedLager = new List<LagerDTO>();

            BussinessLogic.BLL.LagerBLL lagerBLL = new BussinessLogic.BLL.LagerBLL();
         
            public MainPage()
            {
                InitializeComponent();

                
                CollectionViewLager.ItemsSource = lagerBLL.getLagre();


            }

            //private void OnStudentSelectionChanged(object sender, SelectionChangedEventArgs e)
            //{
            //    selectedLager = e.CurrentSelection.Cast<DTO.Model.Lager>().ToList();
            //    Console.WriteLine($"Antal valgte studerende: {selectedStudent.Count}");
            //}


            //private void AddStudentToHold(object sender, EventArgs e)
            //{
            //    var holdId = ((DTO.Model.HoldDetails)HoldId.BindingContext).HoldId;

            //    // Hent alle studerende fra CollectionView
            //    var studentsInView = CollectionViewStudent.ItemsSource as List<DTO.Model.Student>;
            //    if (studentsInView == null)
            //    {
            //        Console.WriteLine("Ingen studerende at tilføje til holdet.");
            //        return;
            //    }

            //    foreach (var student in studentsInView)
            //    {
            //        // Tilføj hver studerende til holdet
            //        studentBLL.AddStudentToHold(student.StudentId, holdId);
            //        Console.WriteLine($"Tilføjet student med ID: {student.StudentId} til hold ID: {holdId}");
            //    }

            //    Console.WriteLine("Alle studerende i CollectionView er blevet tilføjet til holdet.");
            //}

        }

    }
