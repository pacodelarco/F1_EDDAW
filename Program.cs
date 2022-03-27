
List<F1_EDDAW.Piloto> pilotosCenec=new List<F1_EDDAW.Piloto>();
F1_EDDAW.Piloto pacoDelarco = new F1_EDDAW.Piloto("Paco","Del Arco",18);
F1_EDDAW.Piloto joseCoca = new F1_EDDAW.Piloto("Jose", "Coca", 19);
pilotosCenec.Add(pacoDelarco);
pilotosCenec.Add(joseCoca);


List<F1_EDDAW.Equipos> equiposCenec = new List<F1_EDDAW.Equipos>();
F1_EDDAW.Equipos racingCenec = new F1_EDDAW.Equipos("Racing Cenec", "Orain", 30, pilotosCenec);
equiposCenec.Add(racingCenec);   

List<F1_EDDAW.Competicion> competicionesCenec = new List<F1_EDDAW.Competicion>();
F1_EDDAW.Competicion f1 = new F1_EDDAW.Competicion("Formula 1", equiposCenec);
competicionesCenec.Add(f1);


for (int i = 0; i < competicionesCenec.Count; i++)
{
    Console.WriteLine(competicionesCenec[i]);
   
}