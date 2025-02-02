﻿using System;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
	public class ContactsAPIDbContext: DbContext
	{
		public ContactsAPIDbContext(DbContextOptions<ContactsAPIDbContext> options): base(options)
		{

		}

		public DbSet<Contact> Contacts { get; set; }
	}
}

