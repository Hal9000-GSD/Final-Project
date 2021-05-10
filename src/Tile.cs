using System;

class Tile {
  public int xpos;
  public int ypos;
  // The Bool are the directions you can / cant go
  public bool n;
  public bool s;
  public bool e;
  public bool w;
  public string Desc;
  public Tile(int xpos, int ypos, bool n,bool s, bool e, bool w, string Desc){ //Constructor
    this.xpos = xpos;
    this.ypos = ypos;
    this.Desc = Desc;
    this.n = n;
    this.s = s;
    this.e = e;
    this.w = w;
  }
  void editDescription(){

  }
  public string Look(int x, int y){

    if(x == xpos && y == ypos){
       return Desc;
    }
    else{
      return null;
    }
  }
}