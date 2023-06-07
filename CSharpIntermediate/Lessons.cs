namespace CSharpIntermediate
{
    public class Lessons
    {
        public static void LessonOne()
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }

        public static void LessonTwo() {
            var dbMigrator = new DbMigrator(new Logger()); // composition

            var logger = new Logger();
            var installer = new Installer(logger); // composition, other way

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}
