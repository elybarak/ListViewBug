using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;
using Xamarin.Forms;

namespace ListViewBug
{
    class Person : BindableObject
    {
        public IEnumerable<BsonDocument> MyProperty { get; set; }

        public Person()
        {
            MyProperty = new BsonDocument[] {
                new BsonDocument{
                    { "first", "something" },
                    { "second", "SecondSomething" },
                    { "third", "ThirdSomething" }
                },
                 new BsonDocument{
                    { "first", "something" },
                    { "second", "SecondSomething" },
                    { "third", "ThirdSomething" }
                },
                new BsonDocument{
                    { "first", "something" },
                    { "second", "SecondSomething" },
                    { "third", "ThirdSomething" }
                }
            };
        }
    }
}
