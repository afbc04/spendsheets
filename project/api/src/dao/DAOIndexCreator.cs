namespace DAO {

    public class DAOIndexCreator {

        public static async Task TagsName() =>
            await DAOUtils.CreateTableOrIndex(@$"
                CREATE INDEX IF NOT EXISTS idx_tags_name
                ON Tags (name);");

        public static async Task CategoriesName() =>
            await DAOUtils.CreateTableOrIndex(@$"
                CREATE INDEX IF NOT EXISTS idx_categories_name
                ON Categories (name);");

    }

}