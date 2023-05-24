using CustomList;

namespace CustomListTestRemove
{
    [TestClass]
    public class CustomListTestRemove
    {
        [TestMethod]
        public void RemoveItemFromArray_RemoveOneItem_CountDecrements() 
        {
            //arrange

            CustomList<string> myList = new CustomList<string>();
            int indexToRemove = 0;

            //act

            myList.Remove("hello");


            //assert

            Assert.AreEqual("world", myList.Items[0]);
            Assert.AreEqual(3, myList.Count);

        }

        [TestMethod]
        public void ReturnTrueAfterRemoval_RemoveOneItem_MethodReturnsTrue()
        {
            //arrange

            CustomList<string> myList = new CustomList<string>();


            //act


            myList.Remove("hello");



            //assert

            Assert.AreEqual(3, myList.Count);
        }
              public void CountRemainsIfItemIsUnknown_IgnoreUnknownItems_CountDoesNotDecrement()     //Think the Act portion is incorrect
        {
            //arrange

            CustomList<string> myList = new CustomList<string>();
            

            //act


            myList.Remove("");



            //assert

            Assert.AreEqual(4, myList.Count);

           

        }

        public void RemoveItemFromArray_RemoveOneItem_AllItemsShiftBackward() // same as first "Count Decrements" Test Method
        {
            //arrange

            CustomList<string> myList = new CustomList<string>();
            int indexToRemove = 0;

            //act

            myList.Remove("hello");


            //assert

            Assert.AreEqual("world", myList.Items[0]);
            Assert.AreEqual(3, myList.Count);

        }


        public void RemoveItemFromArray_OnlyRemoveOneOfTheItems_IfThereAreMultipleOfTheSameItemRemoveTheFirstOne()  //same as first "Count Decrements" Test Method
        {
            CustomList<string> myList = new CustomList<string>();
            int indexToRemove = 0;

            //act

            myList.Remove("hello");


            //assert

            Assert.AreEqual("world", myList.Items[0]);
            Assert.AreEqual(3, myList.Count);

        }


    }
}