/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 9:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Parcial.Entities
{
	/// <summary>
	/// Description of BandejaEntrada.
	/// </summary>
	public class BandejaEntrada
	{
		
		private string estado;
		private IList<Mail> mails;
		private int codigo;
		
		public BandejaEntrada()
		{
			mails = new IList<Mail>();
		}
		
		public virtual int Codigo
		{
			get
			{
				return codigo;
			}
			set 
			{
				codigo = value;
			}
		}
		
		public virtual string Estado
		{
			get
			{
				return estado;
			}
			
			set
			{
				estado = value;
			}
		}
		
		public virtual IList<Mail> Mails
		{
			get
			{
				return mails;
			}
			set
			{
				mails = value;
			}
		}
	}
}
