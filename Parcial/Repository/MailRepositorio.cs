/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 10:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Parcial.Entities;
using Nhibernate;
using System.Collections.Generic;

namespace Parcial.Repository
{
	/// <summary>
	/// Description of MailRepositorio.
	/// </summary>
	public class MailRepositorio
	{
		ISession sesion;
		
		public MailRepositorio()
		{
		}
		
		public void setSession(ISession sesion){
			this.sesion = sesion;
		}
		
		public ISession getSessionFactory(){
			return sesion;
		}
		
		public void agregarMail(Mail mail){
			getSessionFactory().SaveOrUpdate(cli);
			getSessionFactory().Flush();
		}
		
		public void eliminarMail(int id){
			IQuery query = getSessionFactory().CreateQuery("delete from Mail where codigo = :id");
			query.SetParameter("id",id);
			query.ExecuteUpdate();
			getSessionFactory().Flush();
		}
		
		// la idea es al pasar el contacto sacar el id para pasar mail por id
		
		public Mail MailPorID(int id){
			IQuery query = getSessionFactory().CreateQuery("from mail where codigo = :id");
			query.SetParameter("id",id);
			Mail mail = query.UniqueResult<Cliente>();
			
			return mail;
		}
		
		
	}
}
