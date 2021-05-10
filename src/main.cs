//Ian Miller 2021 Computer Programing 1
using System;

class MainClass {
  int xpos = 0;
  int ypos = 0;
  int Health;
  int DD;
  int DR;
  bool Stop = false;
  string input;
  public static void Main (string[] args) {
    
    //tiles
    //Game Start
    Tile Tile1 = new Tile(0, 0, true, false, true, true, "The First Tile");
    //Field 1
    Tile Tile2 = new Tile(0, 1, false, true, true, false, "Field 1");
    //Field 2
    Tile Tile3 = new Tile(1, 1, true, false, false, true, "Field 2");
    //Destroyed Camp
    Tile Tile4 = new Tile(1, 2, false, true, false, true, "Destroyed camp");
    //Goblin Camp
    Tile Tile5 = new Tile(2, 1, false, false, false, true, "Goblin camp");
    //Town Square
    Tile Tile6 = new Tile(-1, 0, true, false, true, false, "Town Square");
    //market
    Tile Tile7 = new Tile(-1, 1, false, true, true, false, "Market");
    //Cave Entrance
    Tile Tile8 = new Tile(1, 0, false, false, true, true, "Cave Entrance");
    //cave 1
    Tile Tile9 = new Tile(2, 0, false, true, true, false, "cave 1");
    //cave 2
    Tile Tile10 = new Tile(2, -1, true, false, true, false, "cave 2");
    //cave3
    Tile Tile11 = new Tile(1, -1, false, false, true, true, "cave 3");
    //cave 4
    Tile Tile12 = new Tile(0, -1, true, false, false, true, "4");


    var mc = new MainClass();
    while(mc.Stop == false){
      mc.input = Console.ReadLine();
      if(mc.input == "n"){ // Goes North
        mc.ypos ++;
        if(Tile1.n == false && mc.xpos == Tile1.xpos && mc.ypos == Tile1.ypos){
          mc.ypos--;
        }
        else if(Tile2.n == false && mc.xpos == Tile2.xpos && mc.ypos == Tile2.ypos){
          mc.ypos--;
        }
        else if(Tile3.n == false && mc.xpos == Tile3.xpos && mc.ypos == Tile3.ypos){
          mc.ypos--;
        }
        else if(Tile4.n == false && mc.xpos == Tile4.xpos && mc.ypos == Tile4.ypos){
          mc.ypos--;
        }
        else if(Tile5.n == false && mc.xpos == Tile5.xpos && mc.ypos == Tile5.ypos){
          mc.ypos--;
        }
        else if(Tile6.n == false && mc.xpos == Tile6.xpos && mc.ypos == Tile6.ypos){
          mc.ypos--;
        }
        else if(Tile7.n == false && mc.xpos == Tile7.xpos && mc.ypos == Tile7.ypos){
          mc.ypos--;
        }
        else if(Tile8.n == false && mc.xpos == Tile8.xpos && mc.ypos == Tile8.ypos){
          mc.ypos--;
        }
        else if(Tile9.n == false && mc.xpos == Tile9.xpos && mc.ypos == Tile9.ypos){
          mc.ypos--;
        }
        else if(Tile10.n == false && mc.xpos == Tile10.xpos && mc.ypos == Tile10.ypos){
          mc.ypos--;
        }
        else if(Tile11.n == false && mc.xpos == Tile11.xpos && mc.ypos == Tile11.ypos){
          mc.ypos--;
        }
        else if(Tile12.n == false && mc.xpos == Tile12.xpos && mc.ypos == Tile12.ypos){
          mc.ypos--;
        }
        
      }
      else if(mc.input == "s"){ // Goes South
        mc.ypos--;
        if(Tile1.s == false && mc.xpos == Tile1.xpos && mc.ypos == Tile1.ypos){
          mc.ypos++;
        }
        else if(Tile2.s == false && mc.xpos == Tile2.xpos && mc.ypos == Tile2.ypos){
          mc.ypos++;
        }
        else if(Tile3.s == false && mc.xpos == Tile3.xpos && mc.ypos == Tile3.ypos){
          mc.ypos++;
        }
        else if(Tile4.s == false && mc.xpos == Tile4.xpos && mc.ypos == Tile4.ypos){
          mc.ypos++;
        }
        else if(Tile5.s == false && mc.xpos == Tile5.xpos && mc.ypos == Tile5.ypos){
          mc.ypos++;
        }
        else if(Tile6.s == false && mc.xpos == Tile6.xpos && mc.ypos == Tile6.ypos){
          mc.ypos++;
        }
        else if(Tile7.s == false && mc.xpos == Tile7.xpos && mc.ypos == Tile7.ypos){
          mc.ypos++;
        }
        else if(Tile8.s == false && mc.xpos == Tile8.xpos && mc.ypos == Tile8.ypos){
          mc.ypos++;
        }
        else if(Tile9.s == false && mc.xpos == Tile9.xpos && mc.ypos == Tile9.ypos){
          mc.ypos++;
        }
        else if(Tile10.s == false && mc.xpos == Tile10.xpos && mc.ypos == Tile10.ypos){
          mc.ypos++;
        }
        else if(Tile11.s == false && mc.xpos == Tile11.xpos && mc.ypos == Tile11.ypos){
          mc.ypos++;
        }
        else if(Tile12.s == false && mc.xpos == Tile12.xpos && mc.ypos == Tile12.ypos){
          mc.ypos++;
        }
      }

      else if(mc.input == "e"){ // Goes East
        mc.xpos++;
        if(Tile1.e == false && mc.xpos == Tile1.xpos && mc.ypos == Tile1.ypos){
          mc.xpos--;
        }
        else if(Tile2.e == false && mc.xpos == Tile2.xpos && mc.ypos == Tile2.ypos){
          mc.xpos--;
        }
        else if(Tile3.e == false && mc.xpos == Tile3.xpos && mc.ypos == Tile3.ypos){
          mc.xpos--;
        }
        else if(Tile4.e == false && mc.xpos == Tile4.xpos && mc.ypos == Tile4.ypos){
          mc.xpos--;
        }
        else if(Tile5.e == false && mc.xpos == Tile5.xpos && mc.ypos == Tile5.ypos){
          mc.xpos--;
        }
        else if(Tile6.e == false && mc.xpos == Tile6.xpos && mc.ypos == Tile6.ypos){
          mc.xpos--;
        }
        else if(Tile7.e == false && mc.xpos == Tile7.xpos && mc.ypos == Tile7.ypos){
          mc.xpos--;
        }
        else if(Tile8.e == false && mc.xpos == Tile8.xpos && mc.ypos == Tile8.ypos){
          mc.xpos--;
        }
        else if(Tile9.e == false && mc.xpos == Tile9.xpos && mc.ypos == Tile9.ypos){
          mc.xpos--;
        }
        else if(Tile10.e == false && mc.xpos == Tile10.xpos && mc.ypos == Tile10.ypos){
          mc.xpos--;
        }
        else if(Tile11.e == false && mc.xpos == Tile11.xpos && mc.ypos == Tile11.ypos){
          mc.xpos--;
        }
        else if(Tile12.e == false && mc.xpos == Tile12.xpos && mc.ypos == Tile12.ypos){
          mc.xpos--;
        }
      }

      else if(mc.input == "w"){ // Goes West
        mc.xpos--;
        if(Tile1.w == false && mc.xpos == Tile1.xpos && mc.ypos == Tile1.ypos){
          mc.xpos++;
        }
        else if(Tile2.w == false && mc.xpos == Tile2.xpos && mc.ypos == Tile2.ypos){
          mc.xpos++;
        }
        else if(Tile3.w == false && mc.xpos == Tile3.xpos && mc.ypos == Tile3.ypos){
          mc.xpos++;
        }
        else if(Tile4.w == false && mc.xpos == Tile4.xpos && mc.ypos == Tile4.ypos){
          mc.xpos++;
        }
        else if(Tile5.w == false && mc.xpos == Tile5.xpos && mc.ypos == Tile5.ypos){
          mc.xpos++;
        }
        else if(Tile6.w == false && mc.xpos == Tile6.xpos && mc.ypos == Tile6.ypos){
          mc.xpos++;
        }
        else if(Tile7.w == false && mc.xpos == Tile7.xpos && mc.ypos == Tile7.ypos){
          mc.xpos++;
        }
        else if(Tile8.w == false && mc.xpos == Tile8.xpos && mc.ypos == Tile8.ypos){
          mc.xpos++;
        }
        else if(Tile9.w == false && mc.xpos == Tile9.xpos && mc.ypos == Tile9.ypos){
          mc.xpos++;
        }
        else if(Tile10.w == false && mc.xpos == Tile10.xpos && mc.ypos == Tile10.ypos){
          mc.xpos++;
        }
        else if(Tile11.w == false && mc.xpos == Tile11.xpos && mc.ypos == Tile11.ypos){
          mc.xpos++;
        }
        else if(Tile12.w == false && mc.xpos == Tile12.xpos && mc.ypos == Tile12.ypos){
          mc.xpos++;
        }
      }
      else if(mc.input == "look"){
        Console.WriteLine(Tile1.Look(mc.xpos, mc.ypos));
      }
      else{
        Console.WriteLine("Error");
      }
      Console.WriteLine("Xpos:" + mc.xpos);
      Console.WriteLine("Ypos:" + mc.ypos);
    }
  }
  public int Attack(){
    
    return DD;
  }
  public int Hurt(){
    
    return DR;
  }
  void Help(){

  }
}