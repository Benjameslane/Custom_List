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

        public void AddMethod_CountIncrements_CountShouldIncrease()
        {

            //arrange

            CustomList<string> myList = new CustomList<string>();


            //act

            myList.Add("hello");
         

            //assert

            Assert.AreEqual("hello", myList.Count);
        }

        public void AddMethod_CapacityIncreasesWhenExceeded_CapacityShouldDouble() //needs to change
        {

            //arrange

            CustomList<string> myList = new CustomList<string>();


            //act

            myList.Add("hello");


            //assert

            Assert.AreEqual(4, myList.Capacity);
        }

        public void AddMethod_OneItemPersistsAfterCapacityIsIncreased_AtLeastOneOriginalItemIsTheSame() //May be incorrect
        {

            //arrange

            CustomList<string> myList = new CustomList<string>();


            //act

            myList.Add("hello");


            //assert

            Assert.AreEqual("hello", myList.Items[0]);
        }

    }
}