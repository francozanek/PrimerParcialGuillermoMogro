/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 10:03
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
	/// <summary>
	/// Description of MailServicio.
	/// </summary>
	public class MailServicio
	{
		private MailRepositorio repo;
		
		public MailServicio()
		{
			repo =  new MailRepositorio();
		}
		
		public void agregarMail(Mail mail){
			repo.agregarMail(mail);
		}
		
		public void eliminarCliente(int id){
			repo.eliminarMail(id);
		}
		
		public Mail MailPorId(int id){
			return repo.MailPorID(id);
		}
		
	}
}
