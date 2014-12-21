﻿using System.Collections.Generic;
using LeaveManager.Api.Domain;
using LeaveManager.Api.Infrastructure;
using Ninject;

namespace LeaveManager.Api.Query
{
	public class ListLeavesByUserName : IQuery
	{
		public string UserName { get; set; }
	}

	public class ListLeavesByUserNameQueryHandler : IQueryHandler<ListLeavesByUserName, IEnumerable<Leave>>
	{
		[Inject]
		public LeaveReadModelRepository LeaveReadModelRepository { get; set; }
		
		public IEnumerable<Leave> Query(ListLeavesByUserName passIn)
		{
			return LeaveReadModelRepository.GetLeavesByUserName(passIn.UserName);
		}
	}
}