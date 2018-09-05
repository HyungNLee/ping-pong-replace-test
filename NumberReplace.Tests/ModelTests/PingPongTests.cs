using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumberReplace;

namespace NumberReplace.Test
{
  [TestClass]
  public class PingPongTests
  {
    // [TestMethod]
    // public void PingPongReplace_ReplaceMod15WithPingPong_PingPong()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual("ping-pong", testPingPong.PingPongReplace(15));
    // }
    //
    // [TestMethod]
    // public void PingPongReplace_ReplaceMod5WithPong_Pong()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual("pong", testPingPong.PingPongReplace(10));
    // }
    //
    // [TestMethod]
    // public void PingPongReplace_ReplaceMod3WithPing_Ping()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual("ping", testPingPong.PingPongReplace(9));
    // }

    [TestMethod]
    public void PingPongReplace_NumberListTo16()
    {
      PingPong testPingPong = new PingPong();
      List<string> testList = new List<string> {"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong", "16"};
      CollectionAssert.AreEqual(testList, testPingPong.PingPongReplace(16));
    }
  }
}
