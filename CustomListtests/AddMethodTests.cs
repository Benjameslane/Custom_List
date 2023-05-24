using CustomList;


namespace CustomListtests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]

        public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        {
            //arrange (create objects)

            CustomList<string> myList = new CustomList<string>();

            //act (call methods on created objects)

            myList.Add("hello");
            myList.Add("world");

            //assert (what to we expect) Assert.AreEqual();

            Assert.AreEqual("world", myList.Items[1]);


        }

        public void AddMethod_AddOneItems_FirstItemAtIndexZero()
        {
            //arrange (create objects)

            CustomList<string> myList = new CustomList<string>();

            //act (call methods on created objects)

            myList.Add("hello");


            //assert (what to we expect) Assert.AreEqual();

            Assert.AreEqual("world", myList.Items[0]);

        }

    }
}