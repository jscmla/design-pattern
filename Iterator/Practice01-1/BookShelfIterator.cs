using System;

public class BookShelfIterator : Iterator
{
    private BookShelf bookShelf;
    private int index;

    public BookShelfIterator(BookShelf bookShelf)
    {
        this.bookShelf = bookShelf;
        this.index = 0;
    }

    public Boolean hasNext()
    {
        if (index < bookShelf.getLength())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public object next()
    {
        Object book = bookShelf.getBookAt(index);
        index++;

        return book;
    }
}
