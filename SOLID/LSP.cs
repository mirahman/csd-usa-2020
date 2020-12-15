class Trasportation {
    public String name;
    public String GetName(){}
    public void SetName(String str){}

    public double speed;
    public double GetSpeed(){}
    public void SetSpeed(double num){}

    public String engine;
    public String GetEngine(){}
    public void SetEngine(String str){}

    public void StartEngine(){}

}

class Car: Trasportation {
    public override void StartEngine() {
        // 
    }
}

class Bicycle: Trasportation {
    public override void StartEngine() {
        throw new NotImplentedException();
    }
}

// LSP applied 

class Trasportation {
    public String name;
    public String GetName(){}
    public void SetName(String str){}

    public double speed;
    public double GetSpeed(){}
    public void SetSpeed(double num){}

}

class TrasportationWithEngine : Trasportation {

    public String engine;
    public String GetEngine(){}
    public void SetEngine(String str){}

    public void StartEngine(){}
}

class TrasportationWithoutEngine : Trasportation {

    public void StartMoving(){}
}

class Car: TrasportationWithEngine {
    public override void StartEngine() {
        // 
    }
}

class Bicycle: TrasportationWithoutEngine {
    public override void StartMoving() {
        //
    }
}