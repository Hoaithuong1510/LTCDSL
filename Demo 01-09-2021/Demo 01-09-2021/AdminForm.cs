﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_01_09_2021
{
	public partial class AddFeedForm : Form
	{
		private readonly NewsFeedManager _newsManager;
		public bool HasChanges { get; set; }
		public AddFeedForm(NewsFeedManager newsManager)
		{
			_newsManager = newsManager;
			InitializeComponent();
		}

		private void AddFeedForm_Load(object sender, EventArgs e)
		{
			var publishers = _newsManager.GetNewsFeed();
			foreach(var publisher in publishers)
			{
				cbbPublishers.Items.Add(publisher.Name);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var publisherName = cbbPublishers.Text;
			var categoryName = txtCategory.Text;
			var rssLink = txtRssLink.Text;

			if (string.IsNullOrWhiteSpace(publisherName) ||
				string.IsNullOrWhiteSpace(categoryName) ||
				string.IsNullOrWhiteSpace(rssLink))
			{
				MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Lỗi");
				return;
			}

			HasChanges = true;

			var success = _newsManager.AddCategory(publisherName, categoryName, rssLink, false);
			if (success)
			{
				ClearForm();
				return;
			}
			if(MessageBox.Show("Chuyên mục này đã tồn tại. Bạn có muốn cập nhật RSS link không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes )
			{
				_newsManager.AddCategory(publisherName, categoryName, rssLink, true);
			}
			ClearForm();
		}

		private void ClearForm()
		{
			cbbPublishers.Text = " ";
			txtCategory.Text = " ";
			txtRssLink.Text = " ";
		}
	}
}
