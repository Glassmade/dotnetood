namespace CollectionsExamples
{
    interface ICustomDictionary<T,V>
    {
        void populateTheCollectionByOne(T t, V v);
        void removeFromCollectionByOne(T t);
        void updateTheCollectionByOne(T t, V v);
        void countTheCollection();
        void printTheCollection();
        void printTheCollectionByOne(T t);

    }
}
