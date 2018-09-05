using System;
using System.Collections.Generic;

namespace NumberReplace
{
  public class PingPong
  {
    public List<string> PingPongReplace(int number)
    {
      List<string> returnList = new List<string> {};
      int i = 1;
      while (i <= number)
      {
        if (i % 15 == 0)
        {
          returnList.Add("ping-pong");
        }
        else if (i % 5 == 0)
        {
          returnList.Add("pong");
        }
        else if (i % 3 == 0)
        {
          returnList.Add("ping");
        }
        else
        {
          returnList.Add(i.ToString());
        }
        i++;
      }
      return returnList;
    }
  }
}
