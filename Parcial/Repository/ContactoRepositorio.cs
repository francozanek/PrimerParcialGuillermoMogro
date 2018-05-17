/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 10:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic; 
using NHibernate;
using Parcial.Entities;
namespace Parcial.Repository
{
	/// <summary>
	/// Description of ContactoRepositorio.
	/// </summary>
	public class ContactoRepositorio
	{
		ISession sesion;
		
		public ContactoRepositorio()
		{
		}
		
		
		public void setSession(ISession sesion){
			this.sesion = sesion;
		}
		
		public ISession getSessionFactory(){
			return sesion;
		}
		
		public void agregarContacto(Contacto cont){
			getSessionFactory().SaveOrUpdate(cli);
			getSessionFactory().Flush();
		}
		
		public Contacto contactoPorID(int id){
			IQuery query = getSessionFactory().CreateQuery("from Contacto where codigo = :id");
			query.SetParameter("id",id);
			Contacto contacto = query.UniqueResult<Cliente>();
			
			return contacto;
		}
		
		
	}
}
