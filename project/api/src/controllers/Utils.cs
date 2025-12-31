public class Utils {


    public static decimal convert_to_money(ulong money) {
        return money / 100m;
    }

    public static ulong convert_from_money(double money) {

        decimal value = Convert.ToDecimal(money);
        return (ulong) Math.Round(value * 100m, MidpointRounding.AwayFromZero);

    }

    public static string convert_to_datetime(DateTime date) {
        return date.ToString("yyyy-MM-dd HH:mm:ss");
    }

}