/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 10:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Parcial.Repository;
using Parcial.Entities;
using NHibernate;

namespace Parcial.Services
{
	
	
	public class ContactoServicio
	{
		
		private ContactoRepositorio repo;

		public ContactoServicio()
		{
			repo = new ContactoRepositorio();
		}
		
		public void setSession(ISession sesion){
			repo.setSession(sesion);
		}
		
		
		public void agregarContacto(Contacto cont){
			repo.agregarContacto(cont);
		}
		
		public Contacto contactoPorId(int id){
			return repo.contactoPorID(id);
		}
	}
}
