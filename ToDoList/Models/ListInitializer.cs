using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebGrease.Css.Extensions;

namespace ToDoList.Models {
    public class ListInitializer : DropCreateDatabaseIfModelChanges<ListContext> {
        protected override void Seed(ListContext context) {
            GetToDoLists().ForEach(t => context.Lists.Add(t));
            GetListElements().ForEach(e => context.ListElements.Add(e));

            context.SaveChanges();
        }
        private List<ToDoList> GetToDoLists() {
            return new List<ToDoList> {
                new ToDoList() {
                    ToDoListId = 1,
                    CreateDate = DateTime.Parse("14.02.2018"),
                    ListName = "Lista 1"
                },
                new ToDoList() {
                    ToDoListId = 2,
                    CreateDate = DateTime.Parse("14.02.2018"),
                    ListName = "Lista 2"
                },
                new ToDoList() {
                    ToDoListId = 3,
                    CreateDate = DateTime.Parse("15.02.2018"),
                    ListName = "Lista 3"
                },
                new ToDoList() {
                    ToDoListId = 4,
                    CreateDate = DateTime.Parse("13.02.2018"),
                    ListName = "List 4"
                },
                new ToDoList() {
                    ToDoListId = 5,
                    CreateDate = DateTime.Now,
                    ListName = "List 5"
                }
            };
        }
        private List<ListElement> GetListElements() {
            return new List<ListElement> {
                new ListElement() {
                    ListElementId = 1,
                    ListElementText = "Test test test 1 1",
                    ToDoListId = 1
                },
                new ListElement() {
                    ListElementId = 2,
                    ListElementText = "Test test test 1 2",
                    ToDoListId = 1,
                    Priority = 4
                },
                new ListElement() {
                    ListElementId = 3,
                    ListElementText = "Test test test 1 3",
                    ToDoListId = 1
                },
                new ListElement() {
                    ListElementId = 4,
                    ListElementText = "Test test test 2 1",
                    ToDoListId = 2
                },
                new ListElement() {
                    ListElementId = 5,
                    ListElementText = "Test test test 3 1",
                    ToDoListId = 3
                },
                new ListElement() {
                    ListElementId = 6,
                    ListElementText = "Test test test 3 2",
                    ToDoListId = 3
                },
                new ListElement() {
                    ListElementId = 7,
                    ListElementText = "Test test test 3 3",
                    ToDoListId = 3
                },
                new ListElement() {
                    ListElementId = 8,
                    ListElementText = "Test test test 4 1",
                    ToDoListId = 4
                },
                new ListElement() {
                    ListElementId = 9,
                    ListElementText = "Test test test 4 2",
                    ToDoListId = 4
                },
                new ListElement() {
                    ListElementId = 10,
                    ListElementText = "Test test test 5 1",
                    ToDoListId = 5
                },
                new ListElement() {
                    ListElementId = 11,
                    ListElementText = "Test test test 5 2",
                    ToDoListId = 5
                },
                new ListElement() {
                    ListElementId = 12,
                    ListElementText = "Test test test 5 3",
                    ToDoListId = 5
                },
            };
        }
    }
}