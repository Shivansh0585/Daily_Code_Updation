using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListImplementation
{
    /// <summary>
    /// Represents a single node in a singly linked list.
    /// </summary>
    public sealed class Node<T>
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    /// <summary>
    /// A robust generic singly linked list implementation.
    /// Implements ICollection<T> and IReadOnlyCollection<T>.
    /// </summary>
    public class CustomLinkedList<T> : ICollection<T>, IReadOnlyCollection<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        private int _count;
        private int _version;

        public int Count => _count;
        public bool IsReadOnly => false;
        public bool IsEmpty => _count == 0;

        /// <summary>
        /// Gets the first node in the list, or null if empty.
        /// </summary>
        public Node<T>? First => _head;

        /// <summary>
        /// Gets the last node in the list, or null if empty.
        /// </summary>
        public Node<T>? Last => _tail;

        /// <summary>
        /// Adds a new element to the end of the list in O(1) time.
        /// </summary>
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail!.Next = newNode;
                _tail = newNode;
            }

            _count++;
            _version++;
        }

        /// <summary>
        /// Adds a new element to the beginning of the list in O(1) time.
        /// </summary>
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head = newNode;
            }

            _count++;
            _version++;
        }

        /// <summary>
        /// Interface implementation for ICollection<T>.Add (defaults to AddLast).
        /// </summary>
        void ICollection<T>.Add(T item) => AddLast(item);

        /// <summary>
        /// Removes and returns the element at the beginning of the list in O(1) time.
        /// </summary>
        public T RemoveFirst()
        {
            if (_head == null)
                throw new InvalidOperationException("The list is empty.");

            T value = _head.Data;
            _head = _head.Next;

            if (_head == null)
                _tail = null;

            _count--;
            _version++;
            return value;
        }

        /// <summary>
        /// Removes the first occurrence of a specific value from the list.
        /// Returns true if successfully removed; otherwise, false.
        /// </summary>
        public bool Remove(T data)
        {
            if (_head == null) return false;

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            // Target is head node
            if (comparer.Equals(_head.Data, data))
            {
                _head = _head.Next;
                if (_head == null)
                    _tail = null;

                _count--;
                _version++;
                return true;
            }

            // Search in rest of list
            Node<T> current = _head;
            while (current.Next != null && !comparer.Equals(current.Next.Data, data))
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                // Target is tail node
                if (ReferenceEquals(current.Next, _tail))
                {
                    _tail = current;
                }

                current.Next = current.Next.Next;
                _count--;
                _version++;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the list contains a specific value.
        /// </summary>
        public bool Contains(T data)
        {
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            Node<T>? current = _head;

            while (current != null)
            {
                if (comparer.Equals(current.Data, data))
                    return true;

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Removes all elements from the list.
        /// </summary>
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
            _version++;
        }

        /// <summary>
        /// Copies the list elements into a compatible one-dimensional array.
        /// </summary>
        public void CopyTo(T[] array, int arrayIndex)
        {
            ArgumentNullException.ThrowIfNull(array);

            if (arrayIndex < 0 || arrayIndex > array.Length)
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), "Index was out of range.");

            if (array.Length - arrayIndex < _count)
                throw new ArgumentException("The destination array is too small.");

            Node<T>? current = _head;
            while (current != null)
            {
                array[arrayIndex++] = current.Data;
                current = current.Next;
            }
        }

        /// <summary>
        /// Prints all elements to the console in readable format.
        /// </summary>
        public void Display()
        {
            if (_head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node<T>? current = _head;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// Detects modifications during iteration and throws InvalidOperationException.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            int startingVersion = _version;
            Node<T>? current = _head;

            while (current != null)
            {
                if (startingVersion != _version)
                    throw new InvalidOperationException("Collection was modified after the enumerator was instantiated.");

                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static class LinkedListRunner
    {
        public static void RunDemo()
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>();

            Console.WriteLine("=== Adding elements ===");
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddFirst(5);
            list.Display(); // 5 -> 10 -> 20 -> 30 -> null
            Console.WriteLine($"Count: {list.Count}, Head: {list.First?.Data}, Tail: {list.Last?.Data}");

            Console.WriteLine("\n=== Contains check ===");
            Console.WriteLine($"Contains 20? {list.Contains(20)}"); // True
            Console.WriteLine($"Contains 99? {list.Contains(99)}"); // False

            Console.WriteLine("\n=== Removing elements ===");
            list.Remove(20); // removes intermediate node
            list.Display(); // 5 -> 10 -> 30 -> null
            Console.WriteLine($"Count: {list.Count}, Tail: {list.Last?.Data}");

            list.Remove(30); // removes tail node
            list.Display(); // 5 -> 10 -> null
            Console.WriteLine($"Count: {list.Count}, Tail: {list.Last?.Data}");

            int removedFirst = list.RemoveFirst();
            Console.WriteLine($"Removed first: {removedFirst}");
            list.Display(); // 10 -> null

            Console.WriteLine("\n=== Iterating with foreach ===");
            foreach (var item in list)
            {
                Console.WriteLine($"Item: {item}");
            }

            Console.WriteLine("\n=== Clearing list ===");
            list.Clear();
            list.Display(); // List is empty.
            Console.WriteLine($"Count: {list.Count}, IsEmpty: {list.IsEmpty}");
        }
    }
}
