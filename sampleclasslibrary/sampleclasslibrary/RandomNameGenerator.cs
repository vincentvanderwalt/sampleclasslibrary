using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace sampleclasslibrary
{
    public static class RandomNameGenerator
    {
        public static string GetRandomName()
        {
            var randomFullName = RandomizerFactory.GetRandomizer(new FieldOptionsFullName());
            return randomFullName.Generate();
        }
    }
}
