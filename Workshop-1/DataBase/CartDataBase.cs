using Workshop_1.Models;
namespace Workshop_1.DataBase
{
    public static class CartDataBase
    {
        public static List<cart> cartSet = new List<cart>();

        static CartDataBase() 
        {
            cartSet.Add(new cart { id = cartSet.Count+1, number = "1233332255664411", exMonth = "12", exYear = "09", cvv2 = "021", cash = 200_000, idOfOwner = 1 }) ;
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664412", exMonth = "12", exYear = "09", cvv2 = "022", cash = 210_000, idOfOwner = 1 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664413", exMonth = "12", exYear = "09", cvv2 = "023", cash = 220_000, idOfOwner = 1 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664414", exMonth = "12", exYear = "09", cvv2 = "024", cash = 230_000, idOfOwner = 1 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664415", exMonth = "12", exYear = "09", cvv2 = "025", cash = 240_000, idOfOwner = 2 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664416", exMonth = "12", exYear = "09", cvv2 = "026", cash = 250_000, idOfOwner = 2 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664417", exMonth = "12", exYear = "09", cvv2 = "027", cash = 260_000, idOfOwner = 3 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664418", exMonth = "12", exYear = "09", cvv2 = "028", cash = 270_000, idOfOwner = 3 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664419", exMonth = "12", exYear = "09", cvv2 = "029", cash = 280_000, idOfOwner = 4 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664420", exMonth = "12", exYear = "09", cvv2 = "030", cash = 290_000, idOfOwner = 5 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664421", exMonth = "12", exYear = "09", cvv2 = "031", cash = 300_000, idOfOwner = 5 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664422", exMonth = "12", exYear = "09", cvv2 = "032", cash = 310_000, idOfOwner = 6 });
            cartSet.Add(new cart { id = cartSet.Count + 1, number = "1233332255664423", exMonth = "12", exYear = "09", cvv2 = "033", cash = 320_000, idOfOwner = 6 });
        }
    }
}
