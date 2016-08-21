using System;
using System.Collections.Generic;
using System.Linq;
using HttpClientDemo.Models;
using Xamarin.Forms;

namespace HttpClientDemo
{
	public partial class HttpClientDemoPage : ContentPage
	{
		DataService dataService;
		List<TodoItem> items;
		public HttpClientDemoPage()
		{
			InitializeComponent();
			dataService = new DataService();
			RefreshData();
		}

		async void AddButton_Clicked(object sender, System.EventArgs e)
		{
			TodoItem newItem = new TodoItem
			{
				Description = txtTodoItem.Text.Trim(),
				DueDate = dpDueDate.Date.ToString("d")
			};
			await dataService.AddTodoItemAsync(newItem);
			RefreshData();
		}
		public async void OnDone(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);
			TodoItem itemToUpdate = (TodoItem)mi.CommandParameter;
			itemToUpdate.isDone = true;
			//var itemList = todoList.ItemsSource as List<TodoItem>;
			int itemIndex = items.IndexOf(itemToUpdate);
			await dataService.UpdateTodoItemAsync(itemIndex,itemToUpdate);
			RefreshData();
		}

		public async void OnDelete(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);
			TodoItem itemToDelete = (TodoItem)mi.CommandParameter;
			//var itemList = todoList.ItemsSource as List<TodoItem>;
			int itemIndex = items.IndexOf(itemToDelete);
			await dataService.DeleteTodoItemAsync(itemIndex);
			RefreshData();
		}

		async void RefreshData()
		{
			items = await dataService.GetTodoItemsAsync();
			todoList.ItemsSource = items.OrderBy(item => item.isDone).ThenBy(item => item.DueDate).ToList();
		}
	}
}

