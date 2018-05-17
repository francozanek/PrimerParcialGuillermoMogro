/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Parcial.Entities
{
	/// <summary>
	/// Description of Papelera.
	/// </summary>
	public class Papelera
	{
		private int codigo;
		private IList<Mail> mails;
		
		public Papelera()
		{
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
