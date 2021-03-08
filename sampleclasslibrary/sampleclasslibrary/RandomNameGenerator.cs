using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace sampleclasslibrary
{
    public class RandomNameGenerator
    {
        public string GetRandomName()
        {
            var randomFullName = RandomizerFactory.GetRandomizer(new FieldOptionsFullName());
            return randomFullName.Generate();
        }
    }
}
