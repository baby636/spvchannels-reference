﻿using Dapper;
using System;
using System.Data;

namespace SPVChannels.API.Rest.Classes
{
  public class DateTimeHandler : SqlMapper.TypeHandler<DateTime>
  {
    public override void SetValue(IDbDataParameter parameter, DateTime value)
    {
      parameter.Value = value;
    }

    public override DateTime Parse(object value)
    {
      return DateTime.SpecifyKind((DateTime)value, DateTimeKind.Utc);
    }
  }
}
