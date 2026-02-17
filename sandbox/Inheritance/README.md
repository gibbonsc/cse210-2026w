# Inheritance lecture notes

Because of yesterday's Presidents' Day holiday, section 5 students (Mon+Wed 12:45-1:45pm) have both class sessions with me this week, but my section 4 students (Tues+Thurs 9-10am) will only see me Thursday. Section 4 students: my lecture notes are below. Section 5 students: you can have them too! All students: please *finish* your W07 Prepare: Learning Activity before class begins on Wednesday/Thursday. Also, please review these lecture notes, so that we can get started right away on your team activity. - Bro. Gibbons

## Object relationships

### "has-a"

So far we have studied and used examples of data types (classes) that feature relationships like these:

A `Resume` object _has a_ `Person` and _has a_ list of `Job` objects.
A `Journal` object _has a_ list of `Entry` objects.
A `Fraction` object _has a_ numerator (`_top`) number attribute and _has a_ denominator (`_bottom`) number attribute.
A `Till` object _has a_ list of `Bin` objects.
A `Scripture` object _has a_ `Reference` object _has a_ list of `Word` objects.
A `Reference` object _has a_ string attribute `_book` and _has_ some number attributes (`_chapter` and `_verse` numbers).

Almost every simulation you can possibly design can be modeled using **"has a"** relationships, expressed with abstraction and encapsulation principles. Designs based on these principles tend to accurately reflect the real-world realities that object-oriented software can model. Some classes represent **"components"** of other classes. Some classes represent **"aggregates"** of other component classes. You can build "hierarchies" of relationships this way. Objects of a component class become attributes inside objects of an aggregator class.

### "is-a"

Also common among software problems are **_hierarchical domain models_** that specify **"is a"** relationships. Some examples from your learning activity:

A `Student` _is a_ particular type of common `Person`.
A `MathAssignment` _is a_ detailed kind of generic `Assignment`.
A `WritingAssignment` _is a_ specialized variant of `Assignment`.

Such models are **NOT** the same as "has a" component hierarchies. It's not effective to try to model these relationships by placing attributes of a general compoent inside a specialized class. Instead, we'll use a new principle **Inheritance** to model "is a" relationships like this: a specialized class _inherits_ the attributes and behaviors of a generalized class, and extends it with additional capabilities.

#### Synonym time!

Professionals use the following vocabulary as we communicate about inheritance (_"is a"_) relationships between classes of objects:

* _generalized/specalized_: a specialized class _is a_ particular kind of a generalized class
* _super/sub_: a subclass _is a_ specializaiton of a super class.
* _parent/child_: a child class _is an_ inheritor of a parent class.
* _base/derived_: a derived class _is an_ extension of a base class.

### In-class Design Activity

Our classroom activity features collections of object types that we could try to simulate in software. Examples:

* JudgeRetention, Referendum, TaxLevy, NonPartisanOfficial, PartisanOfficial
* Drum, Disc, Hydraulic, ElectroMagnetic, Arrestor
* Bone, Muscle, Nerve, Skin, Blood
* SavingsAccount, DebitAccount, BrokerageAccount, Loan
* Percussion, String, Woodwind, Brass, Voice, ElectronicSynthesizer

Different in-class teams study and try to figure out what the colleciton has in common, design a _parent class_ for their common attributes and behaviors, and design _child classes_ for the attributes and behaviors unique to each type in the colleciton. Examples:

* _base class_ BallotItem, with _derived classes_ NonPartisanOfficial and YesNoItem. NonPartisanOfficial could also be it's own base class with PartisanOfficial as a derived class, and YesNoItem would also be a base class with derived classes JudgeRetention, Referendum, TaxLevy.
  * Common attributes in a civic election simulator's BallotItem class might be `_ballotText`, `_polity`, `_choices`, `_voteTotals`. Common behaviors might be `DisplayChoices()` and `RecordVote()`.
  * A specialized attribute of a NonPartisanOfficial might be `_term`. A specialized behavior might be a `NonPartisanOfficial()` constructor that initializes a lite of candidate choices.
  * A specialized attribute of a PartisanOfficial might be a list of `_parties` participating. A `PartisanOfficial()` constructor would initialize both the parties and each party's nominated candidate.
  * Common attriutes of YesNoItem would be `_choices` constrained to only yes or no.
  * Specialized attributes of a TaxLevy might be `_bondAmount`, `_startDate`, and `_endDate`.

* base class BrakeSystem, with derived classes DrumBrake, DiscBrake, HydraulicBrake, ElectroMagneticBrake, ArrestorGear.
  * Common base attributes `_vehicle`, `_heat`, `_maxSlowRate`; common behaviors `SlowDown()`, `GetTemperature()`.
  * Specific DrumBrake attributes `_drumShape`, `_shoe`; behavior `SqueezeCalipers()`.
  * Specific DiscBrake attribute `_disc`, behavior `CompressDisc()`.
  * Specific HydraulicBrake attribute `_fluidPressure`, behavior `CompressFluid()`.
  * Specific ElectroMagneticBrake attributes `_fieldCoil`, `_armature`; behavior `Actuate()`.
  * Specific ArrestorGear attribute `_externalArrestorSystem`, behavior `Collide()`.

* base class CellularTissue, with derived classes BoneTissue, MuscleTissue, NerveTissue, SkinTissue, BloodTissue, for a cellular biology systems simulator.
  * Common attribute `_cellMatrix`, common behaviors `Mitosis` and `ProduceProtein()`.
  * BoneTissue specialties: a constructor that initalizes `_cellMatrix` to "Calcium structural compound", along with a `BuildStructure() behavior.
  * MuscleTissue specialties: constructor initalizes `_cellMatrix` to "Muscle fiber", along with a `Flex()` behavior.
  * NerveTissue: constructor sets `_cellMatrix` to "Myelin", behavior `Signal()`
  * SkinTissue: constructor sets `_cellMatrix` to "Collagen", behaviors `Sweat()`, `GrowHair()`
  * BloodTissue: `cellMatrix` "Plasma", behaviors `DeliverOxygen()`, `Clot()`.

In class diagrams, inheritance "is a" relationships are shown using an arrow with an _empty triangle outline_ arrowhead attached to the base class. **This is important.** Don't use filled in or stylized arrowheads; such arrows are used in advanced UML diagramming for nuanced "has a" relationships. Your inheritance diagrams **_must always_** have empty outlined triangle "delta" arrowheads. Examples:

![BallotChoices inheritance diagram](BallotChoices.png)

![Brake inheritance diagram](Brake.png)

![CellularTissue inheritance diagram](CellularTissue.png)

### Implementation

C# class code implements a base class using Abstraction and Encapsulation, just like any other class:

```C#
class MusicalInstrument
{
    // base class attributes
    private double _minPitchHz;
    private double _maxPitchHz;
    // base class behaviors
    public void MusicalInstrument(double low, double high)
    {
        _minPitchHz = low; _maxPitchHz = high;
    }
    public double GetLowest() { return _minPitchHz; }
    public double GetHighest() { return _maxPitchHz; }
}
```

Then a derived class inherits using a colon `:` character in the class declaration, and again in the constructor declaration:

```C#
class Woodwind : MusicalInstrument
{
    // additional class attributes
    private string _reedType;
    private string _windColumnShape;
    // behaviors
    public void Woodwind(double low, double high, string reedType, string windColumnShape)
        : base(low, high)
    {
        _reedType = reedType; _windColumnShape = windColumnShape;
    }
    public string GetReedType() { return _minPitchHz; }
    public string GetWindColumnShape() { return _windColumnShape; }
}
```

```C#
class Program
{
    static void Main(string[] args)
    {
        Woodwind altoSaxophone = new Woodwind(
            125.0, 900.0, "single", "cone and bell");
        Woodwind oboe = new Woodwind(
            233.08, 1760.0, "double", "cylinder and bell");
        Woodwind piccolo = new Woodwind(
            587.0, 4186,0, "pursed lips above mouthpiece", "cylinder without bell");
        Console.WriteLine(altoSaxophone.GetLowest());
        Console.WriteLine(oboe.GetHighest());
        Console.WriteLine(piccolo.GetWindColumnShape());
    }
}
``` 
