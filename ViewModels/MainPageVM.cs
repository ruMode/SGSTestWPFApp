using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SGSTestWPFApp.Models;
using System.Collections.ObjectModel;


namespace SGSTestWPFApp.ViewModels
{
    public partial class MainPageVM : ObservableObject
    {
        public MainPageVM()
        {
            
                        //init all lists
            CitiesList =new();
            WorkshopsList = new ();
            EmployeesList  = new();
            SquadsList = new ();


            for (int i = 1; i < 6; i++)
            {
                CitiesList.Add(new Cities()
                {
                    ID = i,
                    TITLE = $"City {i}"
                });

                for (int j = 1; j < 6; j++)
                {
                    WorkshopsList.Add(new Workshops()
                    {
                        ID = CitiesList.Last().ID == 1 ? j : WorkshopsList.Last().ID+1,
                        CITY_ID = CitiesList.Last().ID,
                        TITLE = $"Workshop {WorkshopsList.Count+1}"
                    });

                    for (int k = 1; k < 6; k++)
                    {
                        EmployeesList.Add(new Employees()
                        {
                            ID = WorkshopsList.Last().ID==1?k:EmployeesList.Last().ID +1,
                            CITY_ID = i,
                            WORKSHOP_ID = workshopsList.Last().ID,
                            NAME = $"Employee N{EmployeesList.Count+1}"
                        });
                    }
                }
            }
            for (int l = 1; l < 6; l++)
            {
                SquadsList.Add(new Squads()
                {
                    ID = l,
                    SQUAD_NAME = $"Squad {l}"
                });
            }

            WorkshopsList.Insert(0, new Workshops()
            {
                ID = 0, TITLE = "Все"
            });
            CitiesList.Insert(0, new Cities()
            {
                ID = 0, TITLE = "Все"
            });

            DisplayedWorkshopsList = WorkshopsList;
            DisplayedEmployeesList = EmployeesList;
            DisplayedCitiesList = CitiesList;


        }

        #region Props and Collections

        [ObservableProperty] 
        List<Cities> citiesList, displayedCitiesList;

        [ObservableProperty]
        List<Employees> employeesList, displayedEmployeesList;

        [ObservableProperty]
        List<Workshops> workshopsList, displayedWorkshopsList;

        [ObservableProperty]
        List<Squads> squadsList;

        [ObservableProperty] 
        Cities selectedCity;
       
        [ObservableProperty] 
        Workshops selectedWorkshop;
       
        [ObservableProperty] 
        Employees selectedEmployee;

        [ObservableProperty] 
        Squads selectedSquad;




        #endregion


        [RelayCommand]
        private void CitySelectionChanged()
        {
            if (SelectedCity.ID == 0)
            {
                DisplayedWorkshopsList = WorkshopsList;
                DisplayedEmployeesList = EmployeesList;
            }
            else
            {
                DisplayedWorkshopsList = WorkshopsList.Where(i => i.CITY_ID == SelectedCity.ID).ToList();
                DisplayedEmployeesList = EmployeesList.Where(i => i.CITY_ID == SelectedCity.ID).ToList();
            }
        }

        [RelayCommand]
        private void WorkshopSelectionChanged()
        {
            if (SelectedWorkshop!=null)
            {
                if (SelectedWorkshop.ID == 0)
                {
                    DisplayedWorkshopsList = WorkshopsList;
                }
                else
                    DisplayedEmployeesList = EmployeesList.Where(i => i.WORKSHOP_ID == SelectedWorkshop.ID).ToList();
                
            }
        }


    }
}
