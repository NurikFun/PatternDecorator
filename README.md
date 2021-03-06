# PatternDecorator


Классы должны быть открыты для расширения, но закрыты для изменения.
Декоратор динамически наделяет объект новыми возможностями и является гибкой альтернативой субклассированию в области расширения функциональности.


1. Наследование — одна из форм расширения, но оно не всегда обеспечивает гибкость архитектуры.
2. Следует предусмотреть возможность расширения поведения без изменения существующего кода. 
3. Композиция и делегирование часто используются для динамического добавления нового поведения.
4. Паттерн Декоратор предоставляет альтернативу субклассированию в области расширения поведения.
5. Типы декораторов соответствуют типам декорируемых компонентов (соответствие достигается посредством наследования или реализации интерфейса).
6. Декораторы изменяют поведение компонентов, добавляя новую функциональность до и (или) после (или даже вместо) вызовов методов компонентов.
7. Компонент может декорироваться любым количеством декораторов.
8. Декораторы обычно прозрачны для клиентов компонента (если клиентский код не зависит от конкретного типа компонента).


![Overall picture](https://i.stack.imgur.com/mBVGy.png)

![Overall picture](https://i.stack.imgur.com/Mgecl.png)

